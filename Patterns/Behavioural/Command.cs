using System;

namespace Patterns.Behavioural
{
    /// <summary>
    /// Command
    /// Команда
    /// Client -> Command, Invoker -> Receiver
    /// https://proglib.io/p/behavioral-patterns/
    /// </summary>

    public class Command
    {
        public void Using()
        {
            var bulb = new Bulb();
            var turnOn = new TurnOn(bulb);
            var turnOff = new TurnOff(bulb);

            var remote = new RemoteControl();
            remote.Submit(turnOn);
            remote.Submit(turnOff);
        }
    }

    public interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    }

    public class TurnOn : ICommand
    {
        Bulb bulb;

        public TurnOn(Bulb bulb)
        {
            this.bulb = bulb;
        }

        public void Execute()
        {
            bulb.TurnOn();
        }

        public void Redo()
        {
            Execute();
        }

        public void Undo()
        {
            bulb.TurnOff();
        }
    }

    public class TurnOff : ICommand
    {
        Bulb bulb;

        public TurnOff(Bulb bulb)
        {
            this.bulb = bulb;
        }

        public void Execute()
        {
            bulb.TurnOff();
        }

        public void Redo()
        {
            Execute();
        }

        public void Undo()
        {
            bulb.TurnOn();
        }
    }

    public class Bulb
    {
        public void TurnOn()
        {
            Console.WriteLine($"Bulb is lighting");
        }

        public void TurnOff()
        {
            Console.WriteLine($"Bulb is not lighting");
        }
    }

    //Invoker
    public class RemoteControl
    {
        public void Submit(ICommand command)
        {
            command.Execute();
        }
    }
}
