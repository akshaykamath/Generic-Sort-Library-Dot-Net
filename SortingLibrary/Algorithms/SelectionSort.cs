using Sort.SortContext;
using System.Collections.Generic;

namespace Sort.Algorithms
{
    internal class SelectionSort<T> : ISortable<T>
    {
        IComparer<T> _comparer;

        public SelectionSort(IComparer<T> comparer)
        {
            _comparer = comparer;
        }

        public void Sort(T[] sortableNumbers)
        {
            //int count = 0;
            for (int count = 0; count < sortableNumbers.Length; count++)
            {
                int lowest = count;
                for (int i = count + 1; i < sortableNumbers.Length; i++)
                {
                    if (_comparer.Compare(sortableNumbers[i], sortableNumbers[lowest]) == 1)
                    {
                        lowest = i;
                    }
                }

                SortHelper.Swap(ref sortableNumbers[lowest], ref sortableNumbers[count]);
            }
        }
    }
}
