using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class DdGridView
    {
        public DdGridView()
        {
            DdGridUserColumns = new HashSet<DdGridUserColumn>();
        }

        public int Id { get; set; }
        public int? GridId { get; set; }
        public int? ViewId { get; set; }

        public virtual ICollection<DdGridUserColumn> DdGridUserColumns { get; set; }
    }
}
