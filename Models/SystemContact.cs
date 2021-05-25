using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SystemContact
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public string FullName { get; set; }
        public int? Type { get; set; }
    }
}
