using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SecurityUser
    {
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public bool? UserStatus { get; set; }
        public string UserType { get; set; }
        public string PassWord { get; set; }
        public string Lang { get; set; }
        public bool? MgrFlag { get; set; }
        public string LoginId { get; set; }
        public string Mail { get; set; }
        public int? EmployeeId { get; set; }
        public int? TreasuryId { get; set; }
        public decimal? MaxAllowDiscount { get; set; }
    }
}
