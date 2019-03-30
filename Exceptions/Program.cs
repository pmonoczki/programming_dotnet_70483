using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            strng s = Console.ReadLine();
            int a = int.Parse(s);
            if (a == 42)
                Environment.FailFast("hoppá");
        }    
    }
}
