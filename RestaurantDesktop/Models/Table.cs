using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDesktop.Models
{
    public class Table
    {
        public int ID { get; set; }
        public int ReservationID { get; set; }
        public int NumberOfChairs { get; set; }
    }
}
