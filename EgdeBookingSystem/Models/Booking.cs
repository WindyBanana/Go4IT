using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgdeBookingSystem.Models
{
    public class Booking
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int EquipmentID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
