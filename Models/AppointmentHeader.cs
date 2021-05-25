using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class AppointmentHeader
    {
        public string AppNo { get; set; }
        public string StoCode { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime AppDate { get; set; }
        public DateTime AppStartTime { get; set; }
        public DateTime? AppEndTime { get; set; }
        public string TotalAppTime { get; set; }
        public int? AppNoOfItems { get; set; }
        public decimal? AppTotalValue { get; set; }
        public int? AppPostFlag { get; set; }
        public string SalesTransNo { get; set; }
        public int? SalesTerminalId { get; set; }
        public int? TableId { get; set; }
        public string AppNotes { get; set; }
        public string AppReasons { get; set; }
        public string InsertUid { get; set; }
        public DateTime InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
