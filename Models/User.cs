using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EgdeBooking.Models
{
    public class User
    {
        [Key]
        public string UserEmail { get; set; }
        public int BookingID { get; set; }
        public Booking Booking { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
