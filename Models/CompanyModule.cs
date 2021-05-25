using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class CompanyModule
    {
        public string ModuleId { get; set; }
        public string ComCode { get; set; }
        public string Installed { get; set; }
        public string Integrated { get; set; }
    }
}
