using Newtonsoft.Json;

namespace Likvido.API.Models
{
    public class AuthentificationResponse : ResponseBase<object>
    {
        [JsonProperty("status")]
        public int Status { get; set; } = default;
        
        [JsonProperty("message")]
        public string Message { get; set; } = default;
    }
}