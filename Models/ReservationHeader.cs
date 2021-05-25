using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ReservationHeader
    {
        public string ResTransNo { get; set; }
        public string GuestLastName { get; set; }
        public string GuestFirstName { get; set; }
        public string RoomNo { get; set; }
        public int? PaxPerRoom { get; set; }
        public int? PaxCount { get; set; }
        public int? ChildrenCount { get; set; }
        public int? InfantsCount { get; set; }
        public bool? Suite { get; set; }
        public bool? NoSmoking { get; set; }
        public DateTime? ArrivalDateTime { get; set; }
        public int? Nights { get; set; }
        public DateTime? DepatureDateTime { get; set; }
        public decimal? Price { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
