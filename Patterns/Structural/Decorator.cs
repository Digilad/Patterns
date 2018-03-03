using System;

namespace Patterns.Structural
{
    /// <summary>
    /// Decorator
    /// Декоратор
    /// https://proglib.io/p/structural-patterns/
    /// </summary>

    public class Decorator
    {
        public void Using()
        {
            ICoffee myCoffee = new SimpleCoffee();
            Console.WriteLine(myCoffee.GetCost());
            Console.WriteLine(myCoffee.GetDescription());

            myCoffee = new MilkCoffee(myCoffee);
            Console.WriteLine(myCoffee.GetCost());
            Console.WriteLine(myCoffee.GetDescription());

            myCoffee = new WhipCoffee(myCoffee);
            Console.WriteLine(myCoffee.GetCost());
            Console.WriteLine(myCoffee.GetDescription());
        }
    }

    public interface ICoffee
    {
        float GetCost();
        string GetDescription();
    }

    public class SimpleCoffee : ICoffee
    {
        public float GetCost()
        {
            return 10;
        }

        public string GetDescription()
        {
            return "The simple coffee";
        }
    }

    public class MilkCoffee : ICoffee
    {
        ICoffee coffee;

        public MilkCoffee(ICoffee coffee)
        {
            this.coffee = coffee;
        }
        public float GetCost()
        {
            return coffee.GetCost() + 2;
        }

        public string GetDescription()
        {
            return coffee.GetDescription() + ", milk";
        }
    }

    public class WhipCoffee : ICoffee
    {
        ICoffee coffee;

        public WhipCoffee(ICoffee coffee)
        {
            this.coffee = coffee;
        }
        public float GetCost()
        {
            return coffee.GetCost() + 5;
        }

        public string GetDescription()
        {
            return coffee.GetDescription() + ", whip";
        }
    }
}
