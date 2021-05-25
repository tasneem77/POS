using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Status
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
    }
}
