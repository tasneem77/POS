using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class StockTakeDetail
    {
        public string TransNo { get; set; }
        public int LineSerial { get; set; }
        public int TransType { get; set; }
        public int? SelectedMode { get; set; }
        public string SelectedModeCode { get; set; }
    }
}
