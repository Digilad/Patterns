using System;

namespace Patterns.Creational
{
    /// <summary>
    /// Simple factory
    /// Простая фабрика
    /// https://proglib.io/p/creational-patterns/
    /// </summary>

    public class SimpleFactory
    {
        public void Using()
        {
            var door = DoorFactory.MakeDoor(100, 200);
            Console.WriteLine($"Width: {door.GetWidth()}");
            Console.WriteLine($"Height: {door.GetHeight()}");
        }
    }

    public interface IDoor
    {
        float GetWidth();
        float GetHeight();
    }

    public class WoodenDoor : IDoor
    {
        float width;
        float height;

        public WoodenDoor(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public float GetHeight()
        {
            return height;
        }

        public float GetWidth()
        {
            return width;
        }
    }

    public class DoorFactory
    {
        public static IDoor MakeDoor(float width, float height)
        {
            return new WoodenDoor(width, height);
        }
    }
}
