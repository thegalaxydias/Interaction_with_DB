using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Interaction_with_DB
{
    class SQL
    {
        public static void SelectUsers()
        {

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=db;Integrated Security=True";

                connection.Open();


                SqlCommand command = new SqlCommand("select * from users", connection);


                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    Console.WriteLine("{0} \t{1} \t{2} ", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object login = reader.GetValue(1);
                        object role = reader.GetValue(2);
                        Console.WriteLine("{0} \t{1} \t{2}", id, login, role);
                    }

                }



            }
        }

        public static void InsertUser()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=db;Integrated Security=True";

                connection.Open();

                SqlCommand insert = new SqlCommand("insert into users (id, login, role) values (4, 'larry', 'superadmin')", connection);
                insert.ExecuteNonQuery();

            }
        }

    }
}
