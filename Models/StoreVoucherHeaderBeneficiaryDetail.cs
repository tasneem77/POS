using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class StoreVoucherHeaderBeneficiaryDetail
    {
        public string VoucherNo { get; set; }
        public int LineSerial { get; set; }
        public int? BeneficiaryType { get; set; }
        public string BeneficiaryCode { get; set; }
        public int? BeneficiaryDetailType { get; set; }
        public string BeneficiaryDetailCode { get; set; }
        public string InsertUid { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
