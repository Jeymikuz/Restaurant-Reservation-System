using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWeb.Helpers
{
    public static class Helper
    {
        public static string CnnVal(string name)
        {
            
            // TODO: Ustawione bez appstttings, trzeba poprawic
            return "Server=DESKTOP-OT9FI34\\SQLEXPRESS07;Database=RestaurantDB;Trusted_Connection=True;";
            //return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
