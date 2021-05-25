using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Remark
    {
        public int Id { get; set; }
        public int RemarkType { get; set; }
        public string Remark1 { get; set; }
    }
}
