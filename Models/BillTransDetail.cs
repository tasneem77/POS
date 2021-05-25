using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class BillTransDetail
    {
        public int BillTransSerial { get; set; }
        public string ComCode { get; set; }
        public string StoCode { get; set; }
        public string BillTransNo { get; set; }
        public int? VendorSerial { get; set; }
        public int? AccId { get; set; }
        public decimal? LineQty { get; set; }
        public decimal? LinePrice { get; set; }
        public decimal? LineDiscountValue { get; set; }
        public decimal? TotalCustomValue { get; set; }
        public decimal? VatValue { get; set; }
        public decimal? TotalLineValue { get; set; }
        public string Year { get; set; }
        public string AccInputCode { get; set; }
        public string UpdateUid { get; set; }
        public DateTime UpdateDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
