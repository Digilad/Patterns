using System;

namespace Patterns.Behavioural
{
    /// <summary>
    /// Mediator
    /// Посредник
    /// https://proglib.io/p/behavioral-patterns/
    /// </summary>

    public class Mediator
    {
        public void Using()
        {
            var mediator = new ChatRoom();
            var john = new User("John", mediator);
            var jane = new User("Jane", mediator);
            john.Send("Hello");
            jane.Send("Hi");
        }
    }

    public interface IChatRoomMediator
    {
        void ShowMessage(User user, string message);
    }

    //Mediator
    public class ChatRoom : IChatRoomMediator
    {
        public void ShowMessage(User user, string message)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("dd.MM.yy HH:mm:ss")}] {user.GetName()}: {message}");
        }
    }

    public class User
    {
        private string name;
        private IChatRoomMediator chatMediator;

        public User(string name, IChatRoomMediator chatMediator)
        {
            this.name = name;
            this.chatMediator = chatMediator;
        }

        public string GetName()
        {
            return name;
        }

        public void Send(string message)
        {
            chatMediator.ShowMessage(this, message);
        }
    }
}
