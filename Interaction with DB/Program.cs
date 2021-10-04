using System;
using System.Collections.Generic;
using System.Data.SqlClient;



namespace Interaction_with_DB
{
    class Program
    {
        static void Main(string[] args)
        {
            SQL.InsertUser();
            SQL.SelectUsers();
        }

    }


}
