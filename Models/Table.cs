using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Table
    {
        public int TableId { get; set; }
        public string TableName { get; set; }
        public int? DepartmentId { get; set; }
        public int? Status { get; set; }
        public string CurrentSalesNo { get; set; }
        public string CurrentUser { get; set; }
        public bool? Active { get; set; }
        public DateTime? AccessTime { get; set; }
        public string Remarks { get; set; }
    }
}
