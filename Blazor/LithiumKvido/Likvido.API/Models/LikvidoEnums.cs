namespace Likvido.API.Models
{

    /// <summary>
    /// All enum from swagger
    /// </summary>
    
    public class Schemas
    {
        public enum DiscountType
        {
            Percent = 0,
            Cash = 1
        }

        public enum CompanyName
        {
            Personal = 0,
            IS = 1,
            APS = 2,
            IVS = 3,
            AS = 4,
            SMBA = 5,
            KS = 6,
            SPE = 7,
            SOV = 8,
            FMBA = 9
        }

        public enum CreditorUpdateFrequency
        {
            Never = 0,
            Weekly = 1
        }

        public enum AccountSystemType
        {
            Economic = 0,
            Billy = 1,
            Dinero = 2,
            ReePay = 3,
            Upodi = 4,
            Stripe = 5,
            BusinessCentral = 6,
            Xena = 7,
            Custom = 8
        }

        public enum CreditorStartWeekday
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4
        }

        public enum FoundationType
        {
            InstallmentSignature = 0,
            EnforcementCourt = 1,
            Lawsuit = 2,
            OwnSignature = 3
        }

        public enum InvoiceCloseCode
        {
            Paid = 0,
            PulledBack = 1,
            Objection = 2,
            GivenUp = 3,
            Merged = 4,
            ComplianceFail = 5
        }

        public enum InvoiceState
        {
            New = 0,
            Dunning = 1,
            DebtCollection = 2,
            Objection = 4,
            Installment = 6,
            Done = 7,
            PendingCreation = 9,
            Paused = 10,
            Court = 11,
            PendingData = 12,
            PendingCampaign = 13,
            DataInvalid = 14,
            Invoice = 15,
            PendingAcceptance = 16,
            InternationalDebtCollection = 18,
            PendingDataWaiting = 19,
            PendingInternalCreation = 22
        }

        public enum InvoiceSource
        {
            Manual = 0,
            Import = 1,
            Merged = 2
        }

        public enum InvoiceCloseCodeReason
        {
            Paid_Successful = 0,
            PulledBack_BackWrongData = 1,
            PulledBack_CaseSolvedInternally = 2,
            Objection_DontWantLegal = 3,
            Objection_LackDocumentation = 4,
            GivenUp_DebtorDead = 5,
            GivenUp_DebtorCompanyCeased = 6,
            GivenUp_DebtorPrivateDebtCeased = 7,
            PulledBack_NotAccepted = 8,
            GivenUp_InvalidData = 9,
            PulledBack_DontWantToContinue = 10,
            Merged_CasesMerged = 11,
            PulledBack_CreditNota = 12,
            PulledBack_LikvidoDontWantCase = 13,
            CloseClientAccount = 14,
            ComplianceFail_ExpirationDate = 15,
            ComplianceFail_CompanyIsBankrupt = 16,
            ComplianceFail_ConflictOfInterest = 17,
            GivenUp_ExpirationDateAfterStartup = 18,
            Paid_RemainderWasZero = 19,
            Paid_DebtorBalanceWasZero = 20,
            PulledBack_NonPositiveAmountOnInvoice = 21,
            PulledBack_NonPositiveDebtorBalance = 22,
            ComplianceFail_ErrorCase = 23,
            Objection_LaywerDontWantCase = 24,
            Objection_ClientNotReplyToLaywer = 25
        }

        public enum CampaignType
        {
            DebtCollection = 1,
            Reminders = 5,
            Invoice = 6,
            InternationalDebtCollection = 7
        }

        public enum LegalEntityType
        {
            Private = 0,
            Company = 1
        }

        public enum InvoiceSearchMode
        {
           Active = 0,
           Inactive = 1,
           Finished = 2
        }
        
    }
    
}