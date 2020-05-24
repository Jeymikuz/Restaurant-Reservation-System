using RestaurantWebServer.Models;
using System;
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
        public void InsterResevation(int tablesID, string firstname, string lastname, string email, string phonenumber, DateTime reservationDate, int length);
    }
}