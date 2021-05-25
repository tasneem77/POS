using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class RegLogUser
    {
        public int LoginId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? AccessCode { get; set; }
        public bool? LogType { get; set; }
    }
}
