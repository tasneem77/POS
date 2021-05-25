using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class FunctionsPermssion
    {
        public int Id { get; set; }
        public string UserFunction { get; set; }
        public int? ParentId { get; set; }
    }
}
