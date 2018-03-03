using System;

namespace Patterns.Structural
{
    /// <summary>
    /// Facade
    /// Фасад
    /// https://proglib.io/p/structural-patterns/
    /// </summary>

    public class Facade
    {
        public void Using()
        {
            var computer = new ComputerFacade(new Computer());
            computer.TurnOn();
            computer.TurnOff();
        }
    }

    public class Computer
    {
        public void GetElectricShock()
        {
            Console.WriteLine("Ouch!");
        }

        public void MakeSound()
        {
            Console.WriteLine("Beep beep!");
        }

        public void ShowLoadingScreen()
        {
            Console.WriteLine("Loading...");
        }

        public void CloseEverything()
        {
            Console.WriteLine("Bup bup buzzz");
        }
    }

    public class ComputerFacade
    {
        Computer computer;

        public ComputerFacade(Computer computer)
        {
            this.computer = computer;
        }

        public void TurnOn()
        {
            computer.GetElectricShock();
            computer.MakeSound();
            computer.ShowLoadingScreen();
        }

        public void TurnOff()
        {
            computer.MakeSound();
            computer.CloseEverything();
        }
    }
}
