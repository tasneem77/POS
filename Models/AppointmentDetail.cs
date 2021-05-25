using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class AppointmentDetail
    {
        public string AppNo { get; set; }
        public int AppLineSerial { get; set; }
        public int ItmSerial { get; set; }
        public string MajorTime { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? SalesManId { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitId { get; set; }
        public int? SalesLineSerial { get; set; }
        public string InsertUid { get; set; }
        public DateTime InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
