using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EgdeBooking.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required]
        public string CategoryName { get; set; }

        public ICollection<Equipment> Equipments { get; set; }

    }
}