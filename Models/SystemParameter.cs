using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SystemParameter
    {
        public int Id { get; set; }
        public string ComCode { get; set; }
        public string WindowName { get; set; }
        public string ControlName { get; set; }
        public string ColumnName { get; set; }
        public string Status { get; set; }
        public string InitialValue { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string SpComment { get; set; }
        public string SpShow { get; set; }
        public string DetailDisc { get; set; }
    }
}
