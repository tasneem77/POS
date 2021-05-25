using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Object
    {
        public int Id { get; set; }
        public string ObjectName { get; set; }
        public string EngName { get; set; }
        public string ArabName { get; set; }
        public string FormName { get; set; }
    }
}
