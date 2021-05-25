using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Nationality
    {
        public int Id { get; set; }
        public string Nationality1 { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdaeUid { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
