using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace Likvido.API.Models
{
    /// <summary>
    /// Default/base implementation for api responses
    /// </summary>
    /// <typeparam name="T">Type of class for Data object</typeparam>
    public class ResponseBase<T> 
    {
        public WebException Exception { get; set; } = null;
        public bool IsSuccess { get => this.Exception == null; }
        
        [JsonProperty("data")]
        public T Data { get; set; }
        
        [JsonProperty("errors")]
        public List<ErrorModel> Errors { get; set; }
        
    }
}