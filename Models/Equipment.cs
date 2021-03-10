using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EgdeBooking.Models
{
    public class Equipment
    {
        public int EquipmentID { get; set; }
        [Required]
        public string EquipmentName { get; set; }
        public string Info { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public Category Category { get; set; }
        [Required]
        public string LocationName { get; set; }
        public Location Location { get; set; }
    }
}
