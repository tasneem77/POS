using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class TablesTemp1
    {
        public int TableId { get; set; }
        public string TableName { get; set; }
        public int? DepartmentId { get; set; }
        public int? Status { get; set; }
        public int? CurrentSalesNo { get; set; }
        public string CurrentUser { get; set; }
        public bool? Active { get; set; }
        public DateTime? AccessTime { get; set; }
    }
}
