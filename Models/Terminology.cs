using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Terminology
    {
        public int Id { get; set; }
        public string OriginaLabelName { get; set; }
        public string NewLabelEngName { get; set; }
        public string NewLabelArbName { get; set; }
    }
}
