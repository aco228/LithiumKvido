using System;
using Newtonsoft.Json;

namespace Likvido.API.Models
{
    public class InvoiceResponseModel
    {
        [JsonProperty("id")]
        public string ID { get; set; } = default;
        
        [JsonProperty("type")]
        public string Type { get; set; } = default;
        
        [JsonProperty("attributes")]
        public AttribtueModel Attributes { get; set; } = default;

        [JsonProperty("relationships")]
        public RelationshipsClass Relationships { get; set; } = default;

        /// <summary>
        /// Extension method for getting DebtorID
        /// </summary>
        public int? DebtorID { get => this.Relationships?.debtor?.Data?.Id; }
        public int? CreditorID { get => this.Relationships?.creditor?.Data?.Id; }

        public class AttribtueModel
        {
            [JsonProperty("dateCreated")]
            public DateTime DateCreated {get;set;} = default;

            [JsonProperty("dateUpdated")]
            public DateTime DateUpdated {get;set;} = default;

            [JsonProperty("referenceId")]
            public string ReferenceId {get;set;} = default;

            [JsonProperty("creditorReference")]
            public string CreditorReference {get;set;} = default;

            [JsonProperty("invoiceExpirationDate")]
            public DateTime InvoiceExpirationDate {get;set;} = default;

            [JsonProperty("invoiceFoundation")]
            public bool InvoiceFoundation {get;set;} = default;

            [JsonProperty("currency")]
            public string Currency {get;set;} = default;

            [JsonProperty("netAmount")]
            public double NetAmount {get;set;} = default;

            [JsonProperty("grossAmount")]
            public double GrossAmount {get;set;} = default;

            [JsonProperty("remainder")]
            public double Remainder {get;set;} = default;

            [JsonProperty("vatAmount")]
            public double VatAmount {get;set;} = default;

            [JsonProperty("dueDate")]
            public DateTime DueDate {get;set;} = default;

            [JsonProperty("date")]
            public DateTime Date {get;set;} = default;

            [JsonProperty("closeCode")]
            public Schemas.InvoiceCloseCode CloseCode {get;set;} = default;

            [JsonProperty("invoiceStateOnClose")]
            public Schemas.InvoiceState InvoiceStateOnClose {get;set;} = default;

            [JsonProperty("invoiceState")]
            public Schemas.InvoiceState InvoiceState {get;set;} = default;

            [JsonProperty("invoiceSource")]
            public Schemas.InvoiceSource InvoiceSource {get;set;} = default;

            [JsonProperty("closeCodeReason")]
            public Schemas.InvoiceCloseCodeReason CloseCodeReason {get;set;} = default;

            [JsonProperty("invoiceSourceSystemType")]
            public Schemas.AccountSystemType InvoiceSourceSystemType {get;set;} = default;

            [JsonProperty("closesInvoiceMergedReferenceId")]
            public string ClosesInvoiceMergedReferenceId {get;set;} = default;

            [JsonProperty("initialCampaignTypeRequest")]
            public Schemas.CampaignType InitialCampaignTypeRequest {get;set;} = default;

            [JsonProperty("invoiceComments")]
            public string InvoiceComments {get;set;} = default;

            [JsonProperty("internalComments")]
            public string InternalComments {get;set;} = default;

            [JsonProperty("currentProduct")]
            public Schemas.CampaignType CurrentProduct {get;set;} = default;
        }

        public class RelationshipsClass
        {
            [JsonProperty("debtor")]
            public InvoiceResponseModel.RelatioshipsItem debtor { get; set; } = default;
            [JsonProperty("creditor")]
            public InvoiceResponseModel.RelatioshipsItem creditor { get; set; } = default;
            
        }

        public class RelatioshipsItem
        {
            [JsonProperty("data")]
            public RelatioshipsData Data { get; set; } = default;
        }

        public class RelatioshipsData
        {
            [JsonProperty("data")]
            public string Data { get; set; } = default;
            [JsonProperty("id")]
            public int Id { get; set; } = default;
        }
        
        
    }
}