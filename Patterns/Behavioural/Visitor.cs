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
            var speak = new Speak();
            monkey.Accept(speak);
            lion.Accept(speak);
            dolphin.Accept(speak);
        }
    }

    public interface IAnimal
    {
        void Accept(IAnimalOperation operation);
    }

    public interface IAnimalOperation
    {
        void VisitMonkey(Monkey monkey);
        void VisitLion(Lion lion);
        void VisitDolphin(Dolphin dolphin);
    }

    public class Speak : IAnimalOperation
    {
        public void VisitDolphin(Dolphin dolphin)
        {
            dolphin.Speak();
        }

        public void VisitLion(Lion lion)
        {
            lion.Roar();
        }

        public void VisitMonkey(Monkey monkey)
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

        public void Accept(IAnimalOperation operation)
        {
            operation.VisitMonkey(this);
        }
    }

    public class Lion : IAnimal
    {
        public void Roar()
        {
            Console.WriteLine("Roaaaar!");
        }

        public void Accept(IAnimalOperation operation)
        {
            operation.VisitLion(this);
        }
    }

    public class Dolphin : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Tuut tuttu tuutt!");
        }

        public void Accept(IAnimalOperation operation)
        {
            operation.VisitDolphin(this);
        }
    }
}
