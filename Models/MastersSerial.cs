using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class MastersSerial
    {
        public int Id { get; set; }
        public string MasterName { get; set; }
        public int LastSerial { get; set; }
    }
}
