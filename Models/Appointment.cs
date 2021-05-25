using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? End { get; set; }
        public string Location { get; set; }
        public DateTime? Start { get; set; }
        public string Subject { get; set; }
        public string Properities { get; set; }
        public int? AppLineSerial { get; set; }
        public string Owner { get; set; }
    }
}
