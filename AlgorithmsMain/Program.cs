using System;
using System.Collections.Generic;
using SortingLib;

namespace AlgorithmsMain
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> sortingArray = new List<int>(){ 12,5,2,7,66 };
            int[] sortingArray = { 12, 5, 2, 7, 66 }; 
            IComparer<int> comparer = new SortComparer();

            sortingArray.Sort(SortStrategy.InsertionSort, comparer);

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

            return x < y ? 1 : -1;
        }
    }
}
