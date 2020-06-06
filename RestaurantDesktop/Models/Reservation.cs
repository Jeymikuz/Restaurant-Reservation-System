using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDesktop.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int TableID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime ReservationExpire { get; set; }
        public int ReservationLength { get; set; }
        public bool Accepted { get; set; }
        public bool Canceled { get; set; }


        /*
        public string FullInfo
        {
            get => $"{ReservationID.ToString()} {TableID.ToString()} {FirstName} {LastName} {Email} {PhoneNumber} {ReservationDate.ToString("u")} {ReservationExpire.ToString("u")} {ReservationLength.ToString()} {Accepted.ToString()}";
        }
        */
    }
}
