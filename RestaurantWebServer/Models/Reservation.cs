using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestaurantWebServer.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        [Required]
        public int TableID { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Zbyt długa nazwa (Maksymalnie 30 znaków).")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(60, ErrorMessage = "Zbyt długa nazwa (Maksymalnie 30 znaków).")]
        public string LastName { get; set; }
        [Required]
        [StringLength(120, ErrorMessage = "Zbyt długa nazwa (Maksymalnie 30 znaków).")]
        public string Email { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Zbyt długa nazwa (Maksymalnie 30 znaków).")]
        public string PhoneNumber { get; set; }
        [Required]        
        public DateTime ReservationDate { get; set; }
        public DateTime ReservationExpire { get; set; }
        [Required]
        public int ReservationLength { get; set; }
        public bool Accepted { get; set; }
        public bool Canceled { get; set; }


        public string FullInfo
        {
            get => $"{ReservationID.ToString()} {TableID.ToString()} {FirstName} {LastName} {Email} {PhoneNumber} {ReservationDate.ToString("u")} {ReservationExpire.ToString("u")} {ReservationLength.ToString()} {Accepted.ToString()}";
        }
    }
}
