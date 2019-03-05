using System;
using Npgsql;

namespace ConsumData
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.connectToDB();
        }

        private void connectToDB()
        {
            var connString = "Host=localhosr;Username=palmonoczki;Password=;Database=palmonoczki";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

             

                using (var cmd = new NpgsqlCommand("SELECT some_field FROM products", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        Console.WriteLine(reader.GetString(1));
            }

        }
    
    }
}
