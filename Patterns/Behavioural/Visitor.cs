using System;

namespace Patterns.Behavioural
{
    /// <summary>
    /// Visitor
    /// Посетитель
    /// https://proglib.io/p/behavioral-patterns/
    /// </summary>

    public class Visitor
    {
        public void Using()
        {
            var monkey = new Monkey();
            var lion = new Lion();
            var dolphin = new Dolphin();
            var visitor = new AnimalVisitor();
            monkey.Accept(visitor);
            lion.Accept(visitor);
            dolphin.Accept(visitor);
        }
    }

    public interface IAnimal
    {
        void Accept(IAnimalVisitor operation);
    }

    public interface IAnimalVisitor
    {
        void Visit(Monkey monkey);
        void Visit(Lion lion);
        void Visit(Dolphin dolphin);
    }

    public class AnimalVisitor : IAnimalVisitor
    {
        public void Visit(Dolphin dolphin)
        {
            dolphin.Speak();
        }

        public void Visit(Lion lion)
        {
            lion.Roar();
        }

        public void Visit(Monkey monkey)
        {
            monkey.Shout();
        }
    }

    public class Monkey : IAnimal
    {
        public void Shout()
        {
            Console.WriteLine("Ooh oo aa aa!");
        }

        public void Accept(IAnimalVisitor operation)
        {
            operation.Visit(this);
        }
    }

    public class Lion : IAnimal
    {
        public void Roar()
        {
            Console.WriteLine("Roaaaar!");
        }

        public void Accept(IAnimalVisitor operation)
        {
            operation.Visit(this);
        }
    }

    public class Dolphin : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Tuut tuttu tuutt!");
        }

        public void Accept(IAnimalVisitor operation)
        {
            operation.Visit(this);
        }
    }
}
