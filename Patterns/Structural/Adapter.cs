using System;

namespace Patterns.Structural
{
    /// <summary>
    /// Adapter
    /// Адаптер
    /// https://proglib.io/p/structural-patterns/
    /// </summary>

    public class Adapter
    {
        public void Using()
        {
            var wildDog = new WildDog();
            var wildDogAdapter = new WildDogAdapter(wildDog);
            var hunter = new Hunter();
            hunter.Hunt(wildDogAdapter);
        }
    }

    public class Hunter
    {
        public void Hunt(ILion lion) {
            lion.Roar();
        }
    }

    //Adapter
    public class WildDogAdapter : ILion
    {
        WildDog dog;

        public WildDogAdapter(WildDog dog)
        {
            this.dog = dog;
        }

        public void Roar()
        {
            dog.Bark();
        }
    }

    public interface ILion
    {
        void Roar();
    }

    public class AfricanLion : ILion
    {
        public void Roar()
        {
            Console.WriteLine("African roar");
        }
    }

    public class AsianLion : ILion
    {
        public void Roar()
        {
            Console.WriteLine("Asian roar");
        }
    }

    public class WildDog
    {
        public void Bark()
        {
            Console.WriteLine("Wild dog grrr");
        }
    }
}
