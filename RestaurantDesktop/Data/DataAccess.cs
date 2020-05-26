using RestaurantDesktop.Models;
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

        public List<Reservation> GetAllReservations()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("RestaurantDB")))
            {
                var sql = "exec dbo.Reservation_GetAll";

                var reservations = connection.Query<Reservation>(sql).ToList();                
                return reservations;
            }
        }
        public List<Reservation> GetReservationsByFirstName(string firstName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("RestaurantDB")))
            {
                var sql = "exec dbo.Reservation_GetByFirstName @FirstName";
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

        public List<Table> GetAllTable()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("RestaurantDB")))
            {
                var sql = "exec dbo.GetAllTables";
                


                var tables = connection.Query<Table>(sql).ToList();
                return tables;
            }
        }

        internal void InsterResevation(int tablesID, string firstname, string lastname, string email,string phonenumber, DateTime reservationDate,int length)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("RestaurantDB")))
            {
                var reservations = new List<Reservation>();
                reservations.Add(new Reservation { TableID = tablesID, FirstName = firstname, LastName = lastname, Email = email, PhoneNumber = phonenumber,ReservationDate=reservationDate, ReservationLength = length ,Accepted=true});

                connection.Execute("dbo.Add_Reservation @TableID, @FirstName, @LastName, @Email, @PhoneNumber, @ReservationDate, @ReservationLength, @Accepted", reservations);
            }
        }

        internal void ResevationAccepted(int Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("RestaurantDB")))
            {
                var reservations = new List<Reservation>();

                connection.Execute("exec dbo.UpdateReservation @id", new { id = Id });
            }
        }

        internal void AddNewTable(int NumberOfChairs)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("RestaurantDB")))
            {
                var reservations = new List<Reservation>();

                connection.Execute("exec dbo.Add_Table @NumberOfChairs", new { NumberOfChairs = NumberOfChairs });
            }
        }
    }
}

