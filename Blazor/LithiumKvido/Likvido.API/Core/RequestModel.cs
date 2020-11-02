using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Likvido.API.Models
{
    /// <summary>
    /// Default/base implementation for api requests
    /// </summary>
    public class RequestModel
    {
        /// <summary>
        /// Request headers which will be added on HttpRequest
        /// </summary>
        internal Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Query which can be appended to original action url
        /// For example: creditors which have /Creditors
        ///              can have {id} as exension
        /// </summary>
        internal virtual string _Query { get; set; } = string.Empty;
        

        /// <summary>
        /// Construct QueryString based on values Query and public properties
        /// </summary>
        internal string QueryString
        {
            get
            {
                string queryString = "";
                var properties = this.GetType().GetProperties();
                foreach (var prop in properties)
                {
                    if(prop.GetValue(this) == null)
                        continue;

                    // in caseof collection
                    if (!typeof(string).IsAssignableFrom(prop.PropertyType) && typeof(IEnumerable).IsAssignableFrom(prop.PropertyType))
                    {
                        foreach (var val in prop.GetValue(this) as IEnumerable)
                            queryString += (string.IsNullOrEmpty(queryString) ? "" : "&") + prop.Name + "=" + val.ToString();
                    }
                    else
                    {
                        queryString += (string.IsNullOrEmpty(queryString) ? "" : "&") + prop.Name + "=" + prop.GetValue(this).ToString();   
                    }
                }

                return this._Query + (string.IsNullOrEmpty(queryString) ? "" : "?") + queryString;
            }
        }


        /// <summary>
        /// Add Header to HttpRequest
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void AddHeader(string key, string value)
        {
            if (this.Headers.ContainsKey(key))
                this.Headers[key] = value;
            else
                this.Headers.Add(key, value);
        }

        
        /// <summary>
        /// Add API auth token
        /// </summary>
        /// <param name="token"></param>
        public void Authentificate(string token)
        {
            this.AddHeader("X-ApiKey", token);
        }
    }
}