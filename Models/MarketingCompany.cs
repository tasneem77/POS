using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class MarketingCompany
    {
        public MarketingCompany()
        {
            MarketingCompaniesPeriods = new HashSet<MarketingCompaniesPeriod>();
        }

        public int Id { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public bool Status { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUid { get; set; }

        public virtual ICollection<MarketingCompaniesPeriod> MarketingCompaniesPeriods { get; set; }
    }
}
