using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class DdViewRelation
    {
        public int Id { get; set; }
        public int? ViewId1 { get; set; }
        public int? ViewId2 { get; set; }
        public string RelationQuery { get; set; }
    }
}
