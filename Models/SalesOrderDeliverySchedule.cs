using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class SalesOrderDeliverySchedule
    {
        public string Soserial { get; set; }
        public int DeliveryLineSerial { get; set; }
        public int SoLineSerial { get; set; }
        public int ItmSerial { get; set; }
        public decimal DeliveryQty { get; set; }
        public int UnitId { get; set; }
        public int? CustomerId { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string InsertUid { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
