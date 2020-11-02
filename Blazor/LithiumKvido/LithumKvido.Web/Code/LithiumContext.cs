using Microsoft.AspNetCore.Http;

namespace LithumKvido.Web.Code
{
    public class LithiumContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        
        public HttpContext Context => _httpContextAccessor.HttpContext;

        public LithiumContext(IHttpContextAccessor http)
        {
            this._httpContextAccessor = http;
        }
        
    }
}