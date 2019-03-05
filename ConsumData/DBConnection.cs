using System;
using Npgsql;

namespace ConsumData
{
    public class DBConnection
    {
        public DBConnection()
        {
        }

        /// <summary>
        /// Shows the products.
        /// </summary>
        public void ShowProducts()
        {
            using (var cmd = new NpgsqlCommand("SELECT * FROM products", this.connectToDB()))
            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                    Console.WriteLine(reader.GetString(0));
        }
    

        #region Private

        /// <summary>
        /// The connection string.
        /// </summary>
        private static readonly String CONNECTION_STRING = "Host=127.0.0.1;Port=5432;Username=palmonoczki;Password=;Database=palmonoczki";

        /// <summary>
        /// Connects to db.
        /// </summary>
        /// <returns>The to db.</returns>
        private NpgsqlConnection connectToDB()
        {

            var conn = new NpgsqlConnection(DBConnection.CONNECTION_STRING);
            conn.Open();

            return conn;

        }
        

        #endregion


    }


}
