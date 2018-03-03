using System;

namespace Patterns.Creational
{
    /// <summary>
    /// Singleton
    /// Синглетон
    /// https://proglib.io/p/creational-patterns/
    /// </summary>

    public class Singleton
    {
        public void Using()
        {
            var president1 = President.GetInstance();
            var president2 = President.GetInstance();
            Console.WriteLine(president1 == president2);
        }
    }

    public class President
    {
        private static President instance;
        
        private President() { }

        public static President GetInstance()
        {
            if(instance == null)
            {
                instance = new President();
            }
            return instance;
        }
    }
}
