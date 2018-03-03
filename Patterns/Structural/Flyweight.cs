using System;
using System.Collections.Generic;

namespace Patterns.Structural
{
    /// <summary>
    /// Flyweight
    /// Легковес
    /// https://proglib.io/p/structural-patterns/
    /// </summary>

    public class Flyweight
    {
        public void Using()
        {
            var teaMaker = new TeaMaker();
            var shop = new TeaShop(teaMaker);
            shop.TakeOrder("less sugar", 1);
            shop.TakeOrder("more milk", 2);
            shop.TakeOrder("without sugar", 5);
            shop.Serve();
        }
    }

    public class Tea { }

    public class TeaMaker
    {
        Dictionary<string, Tea> availableTea = new Dictionary<string, Tea>();

        public Tea Make(string preference)
        {
            if(!availableTea.ContainsKey(preference))
            {
                availableTea[preference] = new Tea();
            }
            return availableTea[preference];
        }
    }

    public class TeaShop
    {
        TeaMaker teaMaker;
        Dictionary<int, Tea> orders = new Dictionary<int, Tea>();

        public TeaShop(TeaMaker teaMaker)
        {
            this.teaMaker = teaMaker;
        }

        public void TakeOrder(string teaType, int table)
        {
            orders.Add(table, teaMaker.Make(teaType));
        }

        public void Serve()
        {
            foreach(var o in orders)
            {
                Console.WriteLine($"Bring the tea, table nr. {o.Key}");
            }
        }
    }
}
