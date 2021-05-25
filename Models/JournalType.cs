using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class JournalType
    {
        public int JournalTypesId { get; set; }
        public string PrimaryName { get; set; }
        public string SecondaryName { get; set; }
    }
}
