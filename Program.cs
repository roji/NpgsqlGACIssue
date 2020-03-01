using System;
using Npgsql;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var conn = new NpgsqlConnection("Host=localhost;Database=test;Username=test;Password=test"))
            {
                conn.Open();
            }
        }
    }
}
