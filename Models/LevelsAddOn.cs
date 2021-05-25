using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class LevelsAddOn
    {
        public int LevelId { get; set; }
        public int LevelItemSerial { get; set; }
        public string LevelName { get; set; }
        public int? LevelMaxChoice { get; set; }
        public bool? LevelQtyCheck { get; set; }
        public int? LevelMinChoice { get; set; }
    }
}
