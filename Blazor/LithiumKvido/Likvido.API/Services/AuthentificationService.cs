using System.Threading.Tasks;
using Likvido.API.Models;

namespace Likvido.API.Services
{

    public interface IAuthentificationService
    {
        public Task<AuthentificationResponse> Authentificate();
    }
    
    public class AuthentificationService : LikvidoServiceBase<RequestModel>, IAuthentificationService
    {
        protected override string ActionName { get => "Authentication"; }
        
        public AuthentificationService(LikvidoConfiguration configuration) : base(configuration)
        {
        }

        public Task<AuthentificationResponse> Authentificate()
            => this.GetRequest<AuthentificationResponse, object>(new RequestModel());
    }
}