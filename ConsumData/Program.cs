using System;
using Npgsql;

namespace ConsumData
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnection db = new DBConnection();
            db.ShowProducts();
        }



    }
}
