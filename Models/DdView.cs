using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class DdView
    {
        public int ViewId { get; set; }
        public string ViewName { get; set; }
        public string ViewAbbreviation { get; set; }
        public string ViewType { get; set; }
        public string ViewDescription { get; set; }
    }
}
