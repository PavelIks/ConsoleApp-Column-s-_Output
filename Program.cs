// Вывод столбца //
/*using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace ColumnOutput_s_
{
    class Program
    {
        static SqlConnection connection;
        static void Main()
        {
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=PC_OF_PAVLO\SQLEXPRESS;Initial Catalog=STO;User=PC_of_Pavlo\Pavlo;Integrated Security=True;";
            foreach (var item in GetNames())
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
        static List<string> GetNames()
        {
            List<string> names = new List<string>();
            string sqlExp = "SELECT * FROM [dbo].Services;";
            using (SqlCommand com = new SqlCommand(sqlExp, connection))
            {
                connection.Open();
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        names.Add(reader.GetString(1));
                    }
                }
            }
            return names;
        }
    }
}*/

// Вывод всех столбцов //
/*using System;
using System.Data.SqlClient;
namespace ColumnOutput_s_
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=PC_OF_PAVLO\SQLEXPRESS;Initial Catalog=STO;User=PC_of_Pavlo\Pavlo;Integrated Security=True;";
            connection.Open();
            string sqlExp = "SELECT * FROM [dbo].Services;";
            SqlCommand command = new SqlCommand(sqlExp, connection);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write($"{reader.GetName(i)}\t");
                }
                while (reader.Read())
                {
                    Console.WriteLine();
                    //Console.WriteLine($"{reader[0].ToString()}\t-\t{reader[4]}");
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write($"{reader[i]}\t");
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            Console.Read();
        }
    }
}*/
