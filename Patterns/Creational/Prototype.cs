using System;

namespace Patterns.Creational
{
    /// <summary>
    /// Prototype
    /// Прототип
    /// https://proglib.io/p/creational-patterns/
    /// </summary>

    public class Prototype
    {
        public void Using()
        {
            var original = new Sheep("Dolly");
            Console.WriteLine(original.GetName());
            Console.WriteLine(original.GetCategory());

            var cloned = original;
            cloned.SetName("Jolly");
            Console.WriteLine(cloned.GetName());
            Console.WriteLine(cloned.GetCategory());
        }
    }

    public class Sheep
    {
        string name;
        string category;

        public Sheep(string name, string category = "Mountain sheep")
        {
            this.name = name;
            this.category = category;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetCategory(string category)
        {
            this.category = category;
        }

        public string GetCategory()
        {
            return category;
        }
    }
}
