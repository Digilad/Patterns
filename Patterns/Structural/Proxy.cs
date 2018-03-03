using System;

namespace Patterns.Structural
{
    /// <summary>
    /// Proxy
    /// Заместитель
    /// https://proglib.io/p/structural-patterns/
    /// </summary>

    public class Proxy
    {
        public void Using()
        {
            var door = new Security(new LabDoor());
            door.Open("invalid");
            door.Open("secret");
            door.Close();
        }
    }

    public interface IDoor
    {
        void Open();
        void Close();
    }

    public class LabDoor : IDoor
    {
        public void Close()
        {
            Console.WriteLine("Closing");
        }

        public void Open()
        {
            Console.WriteLine("Opening");
        }
    }

    public class Security
    {
        IDoor door;

        public Security(IDoor door)
        {
            this.door = door;
        }

        public void Open(string password)
        {
            if (Authenticate(password))
            {
                door.Open();
            }
            else
            {
                Console.WriteLine("It's not possible to open the door");
            }
        }

        public bool Authenticate(string password)
        {
            return password == "secret";
        }

        public void Close()
        {
            door.Close();
        }
    }
}
