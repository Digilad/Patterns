using System;

namespace Patterns.Behavioural
{
    /// <summary>
    /// Strategy
    /// Стратегия
    /// https://proglib.io/p/behavioral-patterns/
    /// </summary>
    
    public class Strategy
    {
        public void Using()
        {
            int[] dataSet = new[] { 1, 5, 4, 3, 2, 8 };
            var sorter = new Sorter(new BubbleSortingStrategy());
            sorter = new Sorter(new QuickSortStrategy());
            sorter.Sort(dataSet);
        }
    }

    public interface ISortStrategy
    {
        Array Sort(Array dataSet);
    }

    public class BubbleSortingStrategy : ISortStrategy
    {
        public Array Sort(Array dataSet)
        {
            Console.WriteLine("Bubble sort");
            return dataSet;
        }
    }

    public class QuickSortStrategy : ISortStrategy
    {
        public Array Sort(Array dataSet)
        {
            Console.WriteLine("Quick sort");
            return dataSet;
        }
    }

    public class Sorter
    {
        ISortStrategy sorter;

        public Sorter(ISortStrategy sorter)
        {
            this.sorter = sorter;
        }

        public Array Sort(Array dataSet)
        {
            return sorter.Sort(dataSet);
        }
    }
}
