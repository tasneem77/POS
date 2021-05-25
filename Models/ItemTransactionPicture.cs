using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ItemTransactionPicture
    {
        public int Id { get; set; }
        public int TerminalId { get; set; }
        public string TransNo { get; set; }
        public int? TransLineSerial { get; set; }
        public byte[] Picture { get; set; }
        public int? Type { get; set; }
        public string Remarks { get; set; }
    }
}
