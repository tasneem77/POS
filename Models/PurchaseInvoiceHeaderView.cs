﻿using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class PurchaseInvoiceHeaderView
    {
        public string Piserial { get; set; }
        public int? VendorSerial { get; set; }
        public string VendorNameL1 { get; set; }
        public string VendorNameL2 { get; set; }
        public DateTime? TransDate { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? TotalItemsValue { get; set; }
        public decimal? BaseTotalItemsValue { get; set; }
        public decimal? TotalTaxValue { get; set; }
        public decimal? BaseTotalTaxValue { get; set; }
        public decimal? TotalSalesTaxValue { get; set; }
        public decimal? TotalDiscountValue { get; set; }
        public decimal? BaseTotalDiscountValue { get; set; }
        public string PostFlag { get; set; }
        public string PostFlageDesc { get; set; }
        public DateTime? PostingDate { get; set; }
        public string PostedBy { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal? TotalNoOfItems { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyNameL1 { get; set; }
        public string CurrencyNameL2 { get; set; }
        public string ComCode { get; set; }
        public string CompanyName1 { get; set; }
        public string CompanyName2 { get; set; }
        public string StoCode { get; set; }
        public string StoName1 { get; set; }
        public string StoName2 { get; set; }
        public string Poserial { get; set; }
        public string PurchaseInvoiceDesc { get; set; }
        public int RecievedFlag { get; set; }
        public string RecievedFlagDesc { get; set; }
        public DateTime InsertDate { get; set; }
        public decimal? BaseTotalOthersValue { get; set; }
        public decimal? TotalOthersValue { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? BaseNetAmount { get; set; }
        public decimal TotalQty { get; set; }
        public string Remarks { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? Expenses { get; set; }
        public int? MainVendorId { get; set; }
        public string MainVendorName { get; set; }
    }
}
