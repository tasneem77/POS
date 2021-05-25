using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemCodeGeneration
    {
        public int Id { get; set; }
        public string AttributeName { get; set; }
        public int? Length { get; set; }
        public int? OrderNo { get; set; }
        public bool? Active { get; set; }
        public int? StartDigit { get; set; }
        public string SubstringLayout { get; set; }
    }
}
