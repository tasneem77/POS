using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Classification
    {
        public int ClassificationId { get; set; }
        public string Classification1 { get; set; }
        public int? MainClassificationId { get; set; }
    }
}
