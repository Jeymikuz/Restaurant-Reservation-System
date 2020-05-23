using RestaurantWebServer.Models;
using System.Collections.Generic;

namespace RestaurantWebServer.Data
{
    public interface IDataAccess
    {
        List<Reservation> GetAllReservations();
        List<Table> GetAllTable();
        List<Reservation> GetReservationsByFirstName(string firstName);
        List<Reservation> GetReservationsByFirstNameAndLastName(string firstName, string lastName);
        List<Reservation> GetReservationsByLastName(string lastName);
    }
}