using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class DdGridUserColumn
    {
        public int Id { get; set; }
        public int GridId { get; set; }
        public int? ViewId { get; set; }
        public int? ColumnId { get; set; }
        public string UserCode { get; set; }
        public string DisplayName { get; set; }
        public bool? Fixed { get; set; }
        public bool? GetInGrid { get; set; }
        public bool DisplayInGrid { get; set; }
        public int? OrderNo { get; set; }
        public int? DataLength { get; set; }
        public int? NumberRound { get; set; }
        public bool? GroupPoint { get; set; }

        public virtual DdGridView DdGridView { get; set; }
    }
}
