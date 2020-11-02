using System;
using System.Collections.Generic;

namespace Likvido.API.Models
{
    public class InvoiceFilterModel : RequestModel
    {
        public string Query { get; set; } = default;
        public List<string> Ids { get; set; } = default;
        public List<string> CreditorIds { get; set; } = default;
        public List<string> DebtorIds { get; set; } = default;
        public List<int> CloseCodes { get; set; } = default;
        public List<int> States { get; set; } = default;
        public List<int> DebtorTypes { get; set; } = default;
        public List<int> SearchModes { get; set; } = default;
        public string DateFrom { get; set; } = default;
        public string DateTo { get; set; } = default;
        public bool? IncludeMerged { get; set; } = default;
        public int? Take { get; set; } = default;
        public int? Skip { get; set; } = default;
    }
}