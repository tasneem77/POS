using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class GridDescriptionView
    {
        public int Id { get; set; }
        public int GridId { get; set; }
        public string GridName { get; set; }
        public string GridType { get; set; }
        public string FormName { get; set; }
        public string FormDescription { get; set; }
        public string GridDescription { get; set; }
        public int? ViewId { get; set; }
        public string ViewName { get; set; }
        public string ViewType { get; set; }
        public string ViewAbbreviation { get; set; }
        public string ViewDescription { get; set; }
        public int? ColumnId { get; set; }
        public string ColumnName { get; set; }
        public string ColumnDescription { get; set; }
        public string DisplayName { get; set; }
        public string DataType { get; set; }
        public int DataLength { get; set; }
        public string UserCode { get; set; }
        public bool? GetinGrid { get; set; }
        public bool? Fixed { get; set; }
        public bool DisplayInGrid { get; set; }
        public int OrderNo { get; set; }
        public int NumberRound { get; set; }
        public bool? GroupPoint { get; set; }
    }
}
