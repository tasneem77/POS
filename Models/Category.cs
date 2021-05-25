﻿using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public string PrinterName { get; set; }
        public string Erpcode { get; set; }
        public int? Color { get; set; }
        public int? OrderNo { get; set; }
    }
}
