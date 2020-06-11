using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebServer.Helpers
{
    public static class Helper
    {
        public static string CnnVal(string name)
        {
            return @"Server=DESKTOP-OT9FI34\SQLEXPRESS07;Database=RestaurantDB2;Trusted_Connection=True;";
            //return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
