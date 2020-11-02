using System.Collections.Generic;
using System.Threading.Tasks;
using Likvido.API.Models;
using Likvido.API.Models.Inputs;
using Likvido.API.Models.Responses;

namespace Likvido.API.Services
{

    public interface ICreditorsService
    {
        /// <summary>
        /// Get CreditorResponse by ID
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public Task<ResponseBase<CreditorsResponse>> Get(int id);
        
        /// <summary>
        /// Create new Creditor
        /// </summary>
        /// <param name="creditor"></param>
        /// <returns></returns>
        public Task<ResponseBase<CreditorsResponse>> CreateCreditor(CreditorsCreateModel creditor);
    }
    
    public class CreditorsService : LikvidoServiceBase<RequestModel>, ICreditorsService
    {
        
        protected override string ActionName { get => "Creditors"; }
        
        public CreditorsService(LikvidoConfiguration configuration) : base(configuration)
        {
        }

        public Task<ResponseBase<CreditorsResponse>> Get(int id)
        {
            RequestModel request = new RequestModel()
            {
                _Query = $"/{id}"
            };
            return this.GetRequest<CreditorsResponse>(request);
        }

        public Task<ResponseBase<CreditorsResponse>> CreateCreditor(CreditorsCreateModel creditor)
            => this.PostRequest<CreditorsResponse>(creditor);
        
    }
}