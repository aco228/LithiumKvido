using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Likvido.API.Models
{
    public class InvoiceCreateModel : RequestModel
    {
        [JsonProperty("date")]
        public DateTime Date {get;set;} = DateTime.Today;

        [JsonProperty("dueDate")]
        public DateTime DueDate {get;set;} = DateTime.Now.AddDays(1);

        [JsonProperty("campaignInitialRequest")]
        public Schemas.CampaignType CampaignInitialRequest {get;set;} = default;

        [JsonProperty("currency")]
        public string Currency {get;set;} = default;
        
        [JsonProperty("debtor")]
        public DebtorModel Debtor {get;set;} = new DebtorModel();

        [JsonProperty("lines")]
        public List<LineModel> Lines {get;set;} = new List<LineModel>();

        public class DebtorModel
        {
            [JsonProperty("firstName")]
            public string FirstName {get;set;} = default;

            [JsonProperty("lastName")]
            public string LastName {get;set;} = default;

            [JsonProperty("email")]
            public string Email {get;set;} = default;

            [JsonProperty("phone")]
            public string Phone {get;set;} = default;

            [JsonProperty("debtorType")]
            public Schemas.LegalEntityType DebtorType {get;set;} = default;

            [JsonProperty("address")]
            public string Address {get;set;} = default;

            [JsonProperty("zipCode")]
            public string ZipCode {get;set;} = default;

            [JsonProperty("city")]
            public string City {get;set;} = default;
        }

        public class LineModel
        {
            [JsonProperty("unitNetPrice")]
            public int UnitNetPrice {get;set;} = default;

            [JsonProperty("description")]
            public string Description {get;set;} = default;

            [JsonProperty("quantity")]
            public int Quantity {get;set;} = default;

            [JsonProperty("vatRate")]
            public int VatRate {get;set;} = default;

            [JsonProperty("discountType")]
            public Schemas.DiscountType DiscountType {get;set;} = default;

            [JsonProperty("discountValue")]
            public int DiscountValue {get;set;} = default;

        }
    }
}