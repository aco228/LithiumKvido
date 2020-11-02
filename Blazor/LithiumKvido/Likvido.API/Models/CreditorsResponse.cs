using System;
using Newtonsoft.Json;

namespace Likvido.API.Models.Responses
{
    public class CreditorsResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; } = default;
        
        [JsonProperty("attributes")]
        public AttributeModel Attribute { get; set; } = default;

        public class AttributeModel
        {
            [JsonProperty("dateCreated")]
            public DateTime Created { get;set; } = default;

            [JsonProperty("dateUpdated")]
            public DateTime Updated { get;set; } = default;

            [JsonProperty("slug")]
            public string Slug { get;set; } = default;

            [JsonProperty("companyName")]
            public string CompanyName { get;set; } = default;

            [JsonProperty("companyRegistrationNumber")]
            public string CompanyRegistrationNumber { get;set; } = default;

            [JsonProperty("companyType")]
            public int CompanyType { get;set; } = default;

            [JsonProperty("updateFrequency")]
            public int UpdateFrequency { get;set; } = default;

            [JsonProperty("address")]
            public string Address { get;set; } = default;

            [JsonProperty("zipCode")]
            public string ZipCode { get;set; } = default;

            [JsonProperty("city")]
            public string City { get;set; } = default;

            [JsonProperty("country")]
            public string Country { get;set; } = default;

            [JsonProperty("termsAcceptedLabel")]
            public string TermsAcceptedLabel { get;set; } = default;

            [JsonProperty("nickname")]
            public string Nickname { get;set; } = default;

            [JsonProperty("shortNickName")]
            public string ShortNickName { get;set; } = default;

            [JsonProperty("officeEmail")]
            public string OfficeEmail { get;set; } = default;

            [JsonProperty("officePhone")]
            public string OfficePhone { get;set; } = default;

            [JsonProperty("exemptFromVat")]
            public bool ExemptFromVat { get;set; } = default;

            [JsonProperty("registrationNumber")]
            public string RegistrationNumber { get;set; } = default;

            [JsonProperty("bankAccountNumber")]
            public string BankAccountNumber { get;set; } = default;

            [JsonProperty("ibanCode")]
            public string IbanCode { get;set; } = default;

            [JsonProperty("swiftCode")]
            public string SwiftCode { get;set; } = default;

            [JsonProperty("bankName")]
            public string BankName { get;set; } = default;

            [JsonProperty("accountSystemType")]
            public int AccountSystemType { get;set; } = default;

            [JsonProperty("token")]
            public string Token { get;set; } = default;

            [JsonProperty("settings_Production")]
            public bool SettingsProduction { get;set; } = default;

            [JsonProperty("settings_InvoiceEnabled")]
            public bool SettingsInvoiceEnabled { get;set; } = default;

            [JsonProperty("settings_RemindersEnabled")]
            public bool SettingsRemindersEnabled { get;set; } = default;

            [JsonProperty("settings_DebtCollectionEnabled")]
            public bool SettingsDebtCollectionEnabled { get;set; } = default;

            [JsonProperty("settings_AutoStartDebtCollection")]
            public bool SettingsAutoStartDebtCollection { get;set; } = default;

            [JsonProperty("settings_AutoStartReminders")]
            public bool SettingsAutoStartReminders { get;set; } = default;

            [JsonProperty("settings_AcceptCreditCard")]
            public bool SettingsAcceptCreditCard { get;set; } = default;

            [JsonProperty("settings_ReminderStartAfterDueDate")]
            public int SettingsReminderStartAfterDueDate { get;set; } = default;

            [JsonProperty("settings_ReminderStartOnSpecificDay")]
            public int SettingsReminderStartOnSpecificDay { get;set; } = default;

            [JsonProperty("settings_DebtRegister_RKIReference")]
            public string SettingsDebtRegister_RKIReference { get;set; } = default;

            [JsonProperty("settings_Payments_BetalingsserviceCreditorReference")]
            public string SettingsPayments_BetalingsserviceCreditorReference { get;set; } = default;

            [JsonProperty("settings_Payments_EnableIndbetalingskort")]
            public bool SettingsPayments_EnableIndbetalingskort { get;set; } = default;

            [JsonProperty("onboarding_Accounting_Chosen")]
            public string OnboardingAccounting_Chosen { get;set; } = default;

            [JsonProperty("settings_Payout_Collection_PrincipalPercentage")]
            public int SettingsPayout_Collection_PrincipalPercentage { get;set; } = default;

            [JsonProperty("settings_Payout_DefaultLabel")]
            public string SettingsPayout_DefaultLabel { get;set; } = default;

            [JsonProperty("settings_InvoiceAutoStartFromDate")]
            public DateTime SettingsInvoiceAutoStartFromDate { get;set; } = default;

            [JsonProperty("settings_AutoStartFromDate")]
            public DateTime SettingsAutoStartFromDate { get;set; } = default;

            [JsonProperty("settings_AutoStartMinimumAmount")]
            public int SettingsAutoStartMinimumAmount { get;set; } = default;

            [JsonProperty("creditorLogoUr")]
            public string CreditorLogoUr { get;set; } = default;

        }
    }
}