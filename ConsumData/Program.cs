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
            var connString = "Host=127.0.0.1;Port=5432;Username=palmonoczki;Password=;Database=palmonoczki";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

             

                using (var cmd = new NpgsqlCommand("SELECT * FROM products", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        Console.WriteLine(reader.GetString(0));
            }

        }
    
    }
}
