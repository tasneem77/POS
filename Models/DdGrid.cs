using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class DdGrid
    {
        public int Id { get; set; }
        public string GridName { get; set; }
        public string GridType { get; set; }
        public string FormName { get; set; }
        public string FormDescription { get; set; }
        public string GridDescription { get; set; }
    }
}
