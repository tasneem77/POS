using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class CustomerProfileDocument
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public byte[] AttachFile { get; set; }
        public string Description { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
