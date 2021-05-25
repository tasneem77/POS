using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class MarketingCompaniesPeriod
    {
        public int Id { get; set; }
        public int MarkComId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Status { get; set; }
        public string DiscountType { get; set; }
        public decimal DiscountValue { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUid { get; set; }

        public virtual MarketingCompany MarkCom { get; set; }
    }
}
