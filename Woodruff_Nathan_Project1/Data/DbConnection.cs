using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public static class DbConnection
    {
        private static string Str = "Server=nwoodr94.database.windows.net;Database=PizzaBoxDb;user id=nathan;Password=liberty94!;";
        public static String Connection
        {
            get
            {
                return DbConnection.Str;
            }
        }


    }
}
