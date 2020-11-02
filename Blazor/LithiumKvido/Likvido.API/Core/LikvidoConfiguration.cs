namespace Likvido.API
{
    /// <summary>
    /// Configuration from appsettings.json
    /// </summary>
    public class LikvidoConfiguration
    {
        /// <summary>
        /// API base url
        /// </summary>
        public string BaseURL { get; set; }
        
        /// <summary>
        /// Default api key provided with appsettings
        /// </summary>
        public string ApiKey { get; set; }
    }
}