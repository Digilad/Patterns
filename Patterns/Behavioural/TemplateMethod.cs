using System;

namespace Patterns.Behavioural
{
    /// <summary>
    /// Template method
    /// Шаблонный метод
    /// https://proglib.io/p/behavioral-patterns/
    /// </summary>

    public class TemplateMethod
    {
        public void Using()
        {
            var androidBuilder = new AndroidBuilder();
            androidBuilder.Build();
            var iosBuilder = new IosBuilder();
            iosBuilder.Build();
        }

        public abstract class Builder
        {
            //Template method
            public void Build()
            {
                Test();
                Lint();
                Assemble();
                Deploy();
            }

            abstract public void Test();
            abstract public void Lint();
            abstract public void Assemble();
            abstract public void Deploy();
        }

        public class AndroidBuilder : Builder
        {
            public override void Assemble()
            {
                Console.WriteLine("Assembly Android");
            }

            public override void Deploy()
            {
                Console.WriteLine("Deploying Android");
            }

            public override void Lint()
            {
                Console.WriteLine("Analyze Android code");
            }

            public override void Test()
            {
                Console.WriteLine("Start Android tests");
            }
        }

        public class IosBuilder : Builder
        {
            public override void Assemble()
            {
                Console.WriteLine("Assembly Ios");
            }

            public override void Deploy()
            {
                Console.WriteLine("Deploying Ios");
            }

            public override void Lint()
            {
                Console.WriteLine("Analyze Ios code");
            }

            public override void Test()
            {
                Console.WriteLine("Start Ios tests");
            }
        }
    }
}
