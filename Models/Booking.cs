﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgdeBooking.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string UserEmail { get; set; }
        public int EquipmentID { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}


