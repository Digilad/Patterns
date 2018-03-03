using System;

namespace Patterns.Behavioural
{
    /// <summary>
    /// Visitor
    /// Посетитель
    /// Martin book pg. 589
    /// </summary>

    public class Visitor2
    {
        public void Using()
        {
            var hayes = new HayesModem();
            var zoom = new ZoomModem();
            var ernie = new ErnieModem();
            var unix = new UnixModemConfigurator();
            hayes.Accept(unix);
            zoom.Accept(unix);
            ernie.Accept(unix);
        }
    }

    public interface IModem
    {
        void Accept(IModemVisitor visitor);
    }

    public interface IModemVisitor
    {
        void Visit(HayesModem m);
        void Visit(ZoomModem m);
        void Visit(ErnieModem m);
    }

    public class UnixModemConfigurator : IModemVisitor
    {
        public void Visit(HayesModem m)
        {
            Console.WriteLine("Hayes");
        }

        public void Visit(ZoomModem m)
        {
            Console.WriteLine("Zoom");
        }

        public void Visit(ErnieModem m)
        {
            Console.WriteLine("Ernie");
        }
    }

    public class HayesModem : IModem
    {
        public void Accept(IModemVisitor v)
        {
            v.Visit(this);
        }
    }

    public class ZoomModem : IModem
    {
        public void Accept(IModemVisitor v)
        {
            v.Visit(this);
        }
    }

    public class ErnieModem : IModem
    {
        public void Accept(IModemVisitor v)
        {
            v.Visit(this);
        }
    }
}
