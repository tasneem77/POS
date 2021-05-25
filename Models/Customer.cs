using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? AreaSerial { get; set; }
        public int? HoldingSerial { get; set; }
        public string CurrCode { get; set; }
        public string Type { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public int? StatusFlag { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string PaymentMethod { get; set; }
        public string CreditPeriod { get; set; }
        public decimal? CreditLimit { get; set; }
        public string PriceTypeCode { get; set; }
        public decimal? TotalCredit { get; set; }
        public decimal? TotalDebit { get; set; }
        public decimal? Balance { get; set; }
        public string ContactPerson { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UpdateUid { get; set; }
        public int? MainCustomerId { get; set; }
        public string MainSub { get; set; }
        public int? PaymentDays { get; set; }
        public decimal? RebatePerc { get; set; }
        public int? ClassificationId { get; set; }
        public string CommercialRegistrationNo { get; set; }
        public DateTime? CrexpireDate { get; set; }
        public string MunicipalityApprovalNo { get; set; }
        public DateTime? MrexpireDate { get; set; }
        public string SponserId { get; set; }
        public DateTime? IdexpireDate { get; set; }
        public string Nationality { get; set; }
        public bool? GuranteeCheque { get; set; }
        public string GuranteeChequeNo { get; set; }
        public string GuranteeChequeBank { get; set; }
        public decimal? GuranteeChequeAmount { get; set; }
        public string MailAddress { get; set; }
        public string Pobox { get; set; }
        public int? SalesmanId { get; set; }
    }
}
