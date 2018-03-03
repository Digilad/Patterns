using System;

namespace Patterns.Creational
{
    /// <summary>
    /// Factory method
    /// Фабричный метод
    /// https://proglib.io/p/creational-patterns/
    /// </summary>

    public class FactoryMethod
    {
        public void Using()
        {
            var devManager = new DevelopmentManager();
            devManager.TakeInterview();
            var marketingManager = new MarketingManager();
            marketingManager.TakeInterview();
        }
    }

    public interface IInterviewer
    {
        void AskQuestions();
    }

    public class Developer : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Ask about patterns");
        }
    }

    public class CommunityExecutive : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Ask about public building");
        }
    }

    public abstract class HiringManager
    {
        IInterviewer interviewer;

        abstract public IInterviewer MakeInterviewer();

        public void TakeInterview()
        {
            interviewer = MakeInterviewer();
            interviewer.AskQuestions();
        }
    }

    public class DevelopmentManager : HiringManager
    {
        public override IInterviewer MakeInterviewer()
        {
            return new Developer();
        }
    }

    public class MarketingManager : HiringManager
    {
        public override IInterviewer MakeInterviewer()
        {
            return new CommunityExecutive();
        }
    }
}
