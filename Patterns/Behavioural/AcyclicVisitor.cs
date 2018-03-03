using System;

namespace Patterns.Behavioural
{
    /// <summary>
    /// Visitor
    /// Посетитель
    /// Martin book pg. 593
    /// </summary>

    public class AcyclicVisitor
    {
        public void Using()
        {
            var hayes = new AHayesModem();
            var zoom = new AZoomModem();
            var ernie = new AErnieModem();
            var unix = new AUnixModemConfigurator();
            hayes.Accept(unix);
            zoom.Accept(unix);
            ernie.Accept(unix);
        }
    }

    public interface IAModem
    {
        void Accept(IAModemVisitor visitor);
    }

    public interface IAModemVisitor
    {
    }

    public interface AHayesModemVisitor : IAModemVisitor
    {
        void Visit(AHayesModem m);
    }

    public interface AZoomModemVisitor : IAModemVisitor
    {
        void Visit(AZoomModem m);
    }

    public interface AErnieModemVisitor : IAModemVisitor
    {
        void Visit(AErnieModem m);
    }

    public class AUnixModemConfigurator : AHayesModemVisitor, AZoomModemVisitor, AErnieModemVisitor
    {
        public void Visit(AHayesModem m)
        {
            Console.WriteLine("Hayes A");
        }

        public void Visit(AZoomModem m)
        {
            Console.WriteLine("Zoom A");
        }

        public void Visit(AErnieModem m)
        {
            Console.WriteLine("Ernie A");
        }
    }

    public class AHayesModem : IAModem
    {
        public void Accept(IAModemVisitor v)
        {
            if (v is AHayesModemVisitor)
            {
                (v as AHayesModemVisitor).Visit(this);
            }
        }
    }

    public class AZoomModem : IAModem
    {
        public void Accept(IAModemVisitor v)
        {
            if (v is AZoomModemVisitor)
            {
                (v as AZoomModemVisitor).Visit(this);
            }
        }
    }

    public class AErnieModem : IAModem
    {
        public void Accept(IAModemVisitor v)
        {
            if (v is AErnieModemVisitor)
            {
                (v as AErnieModemVisitor).Visit(this);
            }
        }
    }
}
