using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ClosingPeriod
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public byte[] ScreenShot { get; set; }
    }
}
