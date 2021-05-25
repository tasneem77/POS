using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class UserFunctionsPermission
    {
        public int Id { get; set; }
        public string UserCode { get; set; }
        public int? FunctionPermissionId { get; set; }
        public bool? Autorization { get; set; }
    }
}
