using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Attachement
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string DisplayName { get; set; }
        public string Extension { get; set; }
        public byte[] FileData { get; set; }
        public long? FileSize { get; set; }
        public int? RefrenceType { get; set; }
        public int? RefrenceId { get; set; }
        public string RefrenceTransaction { get; set; }
        public DateTime? UploadDate { get; set; }
        public string UploadBy { get; set; }
    }
}
