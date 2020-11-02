﻿using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Likvido.API.Models;
using Newtonsoft.Json;

namespace Likvido.API
{
    /// <summary>
    /// Base class for all services
    /// </summary>
    /// <typeparam name="TRequest">Default request type for this kind of service</typeparam>
    public abstract class LikvidoServiceBase<TRequest>
        where TRequest : RequestModel
    {
        /// <summary>
        /// Name of action
        /// </summary>
        protected abstract string ActionName { get; }
        
        /// <summary>
        /// Default API key obtained by AuthenticateWith, or Configuration
        /// </summary>
        internal string DefaultApiKey { get; set; } = string.Empty;

        
        /// <summary>
        /// URL of this action, autogenerated based on class implementation
        /// </summary>
        protected string Url
        {
            get => $"{this._configuration.BaseURL}/{this.ActionName}";
        }
        
        private LikvidoConfiguration _configuration;
        
        public LikvidoServiceBase(LikvidoConfiguration configuration)
        {
            this._configuration = configuration;
            if (!string.IsNullOrEmpty(this._configuration.ApiKey))
                this.DefaultApiKey = this._configuration.ApiKey;
        }

        /// <summary>
        /// Internal base method for getting HTTP.GET response from server
        /// </summary>
        /// <returns></returns>
        internal async Task<TResponse> GetRequest<TResponse, TObject>(TRequest input)
            where TResponse : ResponseBase<TObject>
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(this.Url + input.QueryString);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                this.AddHeaders(ref request, input);
                
                using (HttpWebResponse response = (HttpWebResponse) await request.GetResponseAsync())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    string responseContent = await reader.ReadToEndAsync();
                    return JsonConvert.DeserializeObject<TResponse>(responseContent);
                }
            }
            catch (WebException e)
            {
                var result = Activator.CreateInstance(typeof(TResponse)) as TResponse;
                result.Exception = e;
                return result;
            }
        }

        /// <summary>
        /// Proxy method for default abstract ResponseBase class
        /// </summary>
        /// <param name="input"></param>
        /// <typeparam name="T">Type of object to be returned</typeparam>
        /// <returns></returns>
        internal Task<ResponseBase<T>> GetRequest<T>(TRequest input)
            => this.GetRequest<ResponseBase<T>, T>(input);



        /// <summary>
        /// Internal base method for posting to server
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="data"></param>
        /// <param name="contentType"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        internal async Task<TResponse> PostRequest<TResponse, TObj>(TRequest input)
            where TResponse : ResponseBase<TObj>
        {
            try
            {
                string json = JsonConvert.SerializeObject(input);
                byte[] dataBytes = Encoding.UTF8.GetBytes(json);

                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(this.Url + input.QueryString);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.ContentLength = dataBytes.Length;
                request.ContentType = "application/json";
                request.Method = "POST";
                this.AddHeaders(ref request, input);

                using (Stream requestBody = request.GetRequestStream())
                {
                    requestBody.Write(dataBytes, 0, dataBytes.Length);
                }

                using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    string responseContent = await reader.ReadToEndAsync();
                    return JsonConvert.DeserializeObject<TResponse>(responseContent);
                }
            }
            catch (WebException e)
            {
                var result = Activator.CreateInstance(typeof(TResponse)) as TResponse;
                result.Exception = e;
                return result;
            }
        }

        /// <summary>
        /// Proxy method for default return type (ResponseBase)
        /// </summary>
        /// <param name="input"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        internal  Task<ResponseBase<T>> PostRequest<T>(TRequest input)
            => this.PostRequest<ResponseBase<T>, T>(input);


        public void AuthenticateWith(string token)
        {
            this.DefaultApiKey = token;
        }
        
        
        /// <summary>
        /// Add headers from input model
        /// </summary>
        /// <param name="request">Created request</param>
        /// <param name="input">Likvido input model</param>
        private void AddHeaders(ref HttpWebRequest request, RequestModel input)
        {
            if(!string.IsNullOrEmpty(this.DefaultApiKey))
                input.Authentificate(this.DefaultApiKey);
            
            foreach (var header in input.Headers)
                request.Headers.Add(header.Key, header.Value);
        }
        
    }
}