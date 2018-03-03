using System;

namespace Patterns.Creational
{
    /// <summary>
    /// Abstract factory
    /// Абстрактная фабрика
    /// https://proglib.io/p/creational-patterns/
    /// </summary>

    public class AbstractFactory
    {
        public void Using()
        {
            var woodenFactory = new WoodenDoorFactory();
            var door = woodenFactory.MakeDoor();
            var expert = woodenFactory.MakeFittingExpert();
            door.GetDescription();
            expert.GetDescription();

            var ironFactory = new IronDoorFactory();
            door = ironFactory.MakeDoor();
            expert = ironFactory.MakeFittingExpert();
            door.GetDescription();
            expert.GetDescription();
        }
    }

    public interface IDoor2
    {
        void GetDescription();
    }

    public class WoodenDoor2 : IDoor2
    {
        public void GetDescription()
        {
            Console.WriteLine("I am a wooden door");
        }
    }

    public class IronDoor2 : IDoor2
    {
        public void GetDescription()
        {
            Console.WriteLine("I am an iron door");
        }
    }

    public interface IDoorFittingExpert
    {
        void GetDescription();
    }

    public class Welder : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I can fit only iron doors");
        }
    }

    public class Carpenter : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I can fit only wooden doors");
        }
    }

    public interface IDoorFactory2
    {
        IDoor2 MakeDoor();
        IDoorFittingExpert MakeFittingExpert();
    }

    public class WoodenDoorFactory : IDoorFactory2
    {
        public IDoor2 MakeDoor()
        {
            return new WoodenDoor2();
        }

        public IDoorFittingExpert MakeFittingExpert()
        {
            return new Carpenter();
        }
    }

    public class IronDoorFactory : IDoorFactory2
    {
        public IDoor2 MakeDoor()
        {
            return new IronDoor2();
        }

        public IDoorFittingExpert MakeFittingExpert()
        {
            return new Welder();
        }
    }
}
