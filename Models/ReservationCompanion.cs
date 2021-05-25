using System;
using System.Collections.Generic;

#nullable disable

namespace POS_API.Models
{
    public partial class ReservationCompanion
    {
        public int Id { get; set; }
        public string ResTransNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalId { get; set; }
        public string Mobile { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? SpouseDate { get; set; }
    }
}
