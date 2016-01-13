using System;
using Sort.SortContext;
using System.Collections.Generic;
using Sort;

namespace AlgorithmsMain
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortingArray = { 7, 2, 4, 1, 5, 3 };
            IComparer<int> comparer = new SortComparer();

            var sortStrategy = SortStrategyFactory.Instance.GetSortStrategy(SortStrategy.InsertionSort, comparer);
            var context = new SortStrategyContext<int>(sortStrategy);
            context.InvokeSort(sortingArray);

            for (int i = 0; i < sortingArray.Length; i++)
            {
                Console.Write(sortingArray[i] + "\t");
            }

            Console.ReadLine();
        }
    }

    internal class SortComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }

            return x > y ? 1 : -1;
        }
    }
}
