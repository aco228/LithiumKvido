using Newtonsoft.Json;

namespace Likvido.API.Models.Inputs
{
    public class CreditorsCreateModel : RequestModel
    {
        [JsonProperty("sendWelcomeMail")]
        public bool SendWelcomeMail {get;set;} = default;

        [JsonProperty("companyName")]
        public string CompanyName {get;set;} = default;

        [JsonProperty("companyRegistrationNumber")]
        public string CompanyRegistrationNumber {get;set;} = default;

        [JsonProperty("address")]
        public string Address {get;set;} = default;

        [JsonProperty("zipCode")]
        public string ZipCode {get;set;} = default;

        [JsonProperty("city")]
        public string City {get;set;} = default;

        [JsonProperty("officeEmail")]
        public string OfficeEmail {get;set;} = default;

        [JsonProperty("officePhone")]
        public string OfficePhone {get;set;} = default;

    }
}