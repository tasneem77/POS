using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class TransferView
    {
        public string TransNo { get; set; }
        public DateTime? TransDate { get; set; }
        public int? Year { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string ComCode { get; set; }
        public string CompanyNameL1 { get; set; }
        public string CompanyNameL2 { get; set; }
        public string StoCode { get; set; }
        public string FromStoreNameL1 { get; set; }
        public string FromStoreNameL2 { get; set; }
        public string ReturnStoreCode { get; set; }
        public string ToStoreNameL1 { get; set; }
        public string ToStoreNameL2 { get; set; }
        public decimal? TotalOthersValue { get; set; }
        public decimal? TotalNoOfItems { get; set; }
        public string TransferStatus { get; set; }
        public int RecTransSerial { get; set; }
        public int? ItmSerial { get; set; }
        public string ItmCode { get; set; }
        public string ItmCode1 { get; set; }
        public string ItemNameL1 { get; set; }
        public string ItemNameL2 { get; set; }
        public string DescriptionInSales { get; set; }
        public string GroupCode { get; set; }
        public string GroupNameL1 { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryNameL1 { get; set; }
        public int? ModelId { get; set; }
        public string ModelDescription { get; set; }
        public string TransMeasureUnit { get; set; }
        public string UnitNameL1 { get; set; }
        public string UnitNameL2 { get; set; }
        public decimal? OtherCostValue { get; set; }
        public decimal? TotalQtyCost { get; set; }
        public string InsertUid { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string RequisitionNo { get; set; }
        public string TransferDesc { get; set; }
        public decimal? TransQty { get; set; }
        public decimal? DelivQty { get; set; }
        public decimal? NotDelivQty { get; set; }
        public string ItemTransferStatus { get; set; }
        public string ModelCode { get; set; }
        public string XAttributeValue { get; set; }
        public string YAttributeValue { get; set; }
        public decimal? TotalItemsValue { get; set; }
        public string PostFlag { get; set; }
        public string PostingDesc { get; set; }
        public DateTime? PostingDate { get; set; }
        public decimal? ItmSalesPrice { get; set; }
        public string PostedBy { get; set; }
    }
}
