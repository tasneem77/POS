using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemGender
    {
        public int? GederId { get; set; }
        public string GenderCode { get; set; }
        public string GenderNameL1 { get; set; }
        public string GenderNameL2 { get; set; }
    }
}
