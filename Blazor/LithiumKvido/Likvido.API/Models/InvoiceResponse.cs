using System.Collections.Generic;

namespace Likvido.API.Models
{
 
    /// <summary>
    /// Single instance response
    /// </summary>
    public class InvoiceResponse : ResponseBase<InvoiceResponseModel>
    {
        
    }
    
    /// <summary>
    /// Multiple responses, with list
    /// </summary>
    public class InvoicesResponse : ResponseBase<List<InvoiceResponseModel>>
    {
        
    }
}