namespace Patterns.Creational
{
    /// <summary>
    /// Builder
    /// Строитель
    /// https://proglib.io/p/creational-patterns/
    /// </summary>

    public class Builder
    {
        public void Using()
        {
            var burger = new BurgerBuilder(14)
                .AddPepperoni()
                .AddLettuce()
                .AddTomato()
                .Build();
        }
    }

    public class Burger
    {
        int size;
        bool cheese;
        bool pepperoni;
        bool lettuce;
        bool tomato;

        public Burger(BurgerBuilder builder)
        {
            size = builder.size;
            cheese = builder.cheese;
            pepperoni = builder.pepperoni;
            lettuce = builder.lettuce;
            tomato = builder.tomato;
        }
    }

    public class BurgerBuilder
    {
        public int size;
        public bool cheese;
        public bool pepperoni;
        public bool lettuce;
        public bool tomato;

        public BurgerBuilder(int size)
        {
            this.size = size;
        }

        public BurgerBuilder AddPepperoni()
        {
            pepperoni = true;
            return this;
        }

        public BurgerBuilder AddLettuce()
        {
            lettuce = true;
            return this;
        }

        public BurgerBuilder AddCheese()
        {
            cheese = true;
            return this;
        }

        public BurgerBuilder AddTomato()
        {
            tomato = true;
            return this;
        }

        public Burger Build()
        {
            return new Burger(this);
        }
    }
}
