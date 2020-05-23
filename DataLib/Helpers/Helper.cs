using System;
using System.Collections.Generic;
using System.Text;

namespace DataLib.Helpers
{
    class Helper
    {
        public static string CnnVal(string name)
        {

            // TODO: Ustawione bez appstttings, trzeba poprawic
            return "Server=DESKTOP-OT9FI34\\SQLEXPRESS07;Database=RestaurantDB;Trusted_Connection=True;";
            //return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
