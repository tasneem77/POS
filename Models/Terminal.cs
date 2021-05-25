using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Terminal
    {
        public int TermCode { get; set; }
        public string NameL1 { get; set; }
        public string NameL2 { get; set; }
        public int DepartmentId { get; set; }
        public bool? AutoLogout { get; set; }
        public bool? IsDefault { get; set; }
        public bool? Status { get; set; }
        public DateTime LastUdpate { get; set; }
        public string UserId { get; set; }
        public string PhysicalName { get; set; }
    }
}
