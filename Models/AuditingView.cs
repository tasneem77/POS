using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class AuditingView
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string AcName { get; set; }
        public string Note { get; set; }
        public DateTime? LogStart { get; set; }
        public DateTime? LogEnd { get; set; }
    }
}
