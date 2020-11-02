using Newtonsoft.Json;

namespace Likvido.API.Models
{
    public class ErrorModel
    {
        [JsonProperty("status")]
        public int Status { get; set; } = default;
        
        [JsonProperty("code")]
        public string Code { get; set; } = default;
        
        [JsonProperty("title")]
        public string Title { get; set; } = default;
    }
}