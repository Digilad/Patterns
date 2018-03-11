using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Behavioural.Visitor3();
            a.Using();
            Console.ReadLine();
        }
    }
}
