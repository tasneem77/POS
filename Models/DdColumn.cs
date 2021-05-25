using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class DdColumn
    {
        public int Id { get; set; }
        public int? ColumnId { get; set; }
        public int? ViewId { get; set; }
        public string ColumnName { get; set; }
        public string ColumnDescription { get; set; }
        public string DataType { get; set; }
        public bool? Fixed { get; set; }
        public bool? GetInGrid { get; set; }
        public bool? DisplayInGrid { get; set; }
    }
}
