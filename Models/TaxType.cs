using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class TaxType
    {
        public TaxType()
        {
            TaxTemplates = new HashSet<TaxTemplate>();
        }

        public int Id { get; set; }
        public string TaxCode { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public string Describtion { get; set; }
        public bool? Status { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UserId { get; set; }

        public virtual ICollection<TaxTemplate> TaxTemplates { get; set; }
    }
}
