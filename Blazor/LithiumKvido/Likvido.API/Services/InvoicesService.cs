using System.Collections.Generic;
using System.Threading.Tasks;
using Likvido.API.Models;

namespace Likvido.API.Services
{

    public interface IInvoiceService
    {
        /// <summary>
        /// Get all invoice records
        /// </summary>
        /// <returns></returns>
        Task<InvoicesResponse> GetAll();
        
        /// <summary>
        /// Get single invoice record
        /// </summary>
        /// <param name="id">GUID of the Invoice</param>
        /// <returns></returns>
        Task<InvoiceResponse> Get(string id);

        /// <summary>
        /// Filter results
        /// </summary>
        /// <param name="filter">Filter</param>
        /// <returns></returns>
        Task<InvoicesResponse> Get(InvoiceFilterModel filter);
        
        /// <summary>
        /// Create new invoice
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<InvoiceResponse> Create(InvoiceCreateModel input);
    }
    
    public class InvoicesService : LikvidoServiceBase<RequestModel>, IInvoiceService
    {
        protected override string ActionName { get => "Invoices"; }
        
        public InvoicesService(LikvidoConfiguration configuration) : base(configuration){}

        public Task<InvoicesResponse> GetAll()
            => this.GetRequest<InvoicesResponse, List<InvoiceResponseModel>>(new RequestModel());

        
        public Task<InvoiceResponse> Get(string id)
        {
            var request = new RequestModel()
            {
                _Query =  "/" + id
            };
            
            return this.GetRequest<InvoiceResponse, InvoiceResponseModel>(request);
        }

        public Task<InvoicesResponse> Get(InvoiceFilterModel filter)
            => this.GetRequest<InvoicesResponse, List<InvoiceResponseModel>>(filter);

        public Task<InvoiceResponse> Create(InvoiceCreateModel input)
            => this.PostRequest<InvoiceResponse, InvoiceResponseModel>(input);

        
    }
}