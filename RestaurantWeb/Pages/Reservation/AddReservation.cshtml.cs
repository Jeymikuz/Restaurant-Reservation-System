using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantWeb.Models;
using RestaurantWeb.Data;


namespace RestaurantWeb.Pages.Reservation
{
    public class AddReservationModel : PageModel
    {
        public List<DateTime> days = new List<DateTime>();
        public List<Models.Reservation> reservations = new List<Models.Reservation>();
        public List<Table> tables = new List<Table>();

        [BindProperty]
        public Models.Reservation Reservation { get; set; }
        public Table table { get; set; }

        public void OnGet()
        {
            var db = new DataAccess();
            reservations = db.GetAllReservations();
            tables = db.GetAllTable();

            DaysInit();

        }

        private void DaysInit()
        {
            for (double i = 0; i <= 7; i++)
            {
                var day = DateTime.Now;
                if (i > 0)
                {
                    days.Add(day.Date.AddDays(i));
                }
                else
                {
                    days.Add(day);
                }
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false) 
            {
                return Page();
            }

            return RedirectToPage("/Index");
        }


        
        
    }
}