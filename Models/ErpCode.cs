using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ErpCode
    {
        public int? CodesSysId { get; set; }
        public string PrimaryName { get; set; }
        public string SecondaryName { get; set; }
        public int? CodeTypesId { get; set; }
        public string UserCode { get; set; }
        public int Id { get; set; }
    }
}
