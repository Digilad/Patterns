using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Behavioural.AcyclicVisitor();
            a.Using();
            Console.ReadLine();
        }
    }
}
