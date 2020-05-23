using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebServer.Models
{
    public class Table
    {
        public int TableID { get; set; }
        public int ReservationID { get; set; }
        public int NumberOfChairs { get; set; }

        public string CharsAndID
        {
            get => $"Number stolika: {TableID.ToString()}, Ilosc miejsc: {NumberOfChairs.ToString()}";
        }
    }
}
