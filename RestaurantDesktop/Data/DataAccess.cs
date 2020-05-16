﻿using RestaurantDesktop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using RestaurantDesktop.Helpers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace RestaurantDesktop.Data
{
    public class DataAccess
    {
        // Zwraca liste rezerwacji sortowanych po Imieniu
        public List<Reservation> GetReservationsByFirstName(string firstName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("RestaurantDB")))
            {
                var sql = "dbo.Reservation_GetByFirstName @FirstName";
                var values = new { FirstName = firstName };

                var reservations = connection.Query<Reservation>(sql,values).ToList();
                return reservations;
            }
            
        }

        // Zwraca liste rezerwacji sortowanych po Nazwisku
        public List<Reservation> GetReservationsByLastName(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("RestaurantDB")))
            {
                var sql = "exec dbo.Reservation_GetByLastName @LastName";
                var values = new { LastName = lastName };


                var reservations = connection.Query<Reservation>(sql,values).ToList();
        
                return reservations;
            }
        }

        // Zwraca liste rezerwacji sortowanych po Imieniu i Nazwisku
        public List<Reservation> GetReservationsByFirstNameAndLastName(string firstName,string lastName)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("RestaurantDB")))
            {
                var sql = "exec dbo.Reservation_GetByFirstAndLastName @FirstName, @LastName";
                var values = new { FirstName = firstName, LastName = lastName };


                var reservations = connection.Query<Reservation>(sql,values).ToList();
                return reservations;
            }
        }

    }
}
