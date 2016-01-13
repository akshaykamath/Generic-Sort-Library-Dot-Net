using Sort.SortContext;
using System.Collections.Generic;

namespace Sort.Algorithms
{
    internal class BubbleSort<T>: ISortable<T>
    {
        IComparer<T> _comparer;

        public BubbleSort(IComparer<T> comparer)
        {
            _comparer = comparer;
        }

        public void Sort(T[] sortingArray)
        {
            int length = sortingArray.Length;
            bool swap = false;
            do
            {
                swap = false;
                for (int i = 0; i < length - 1; i++)
                {
                    if (_comparer.Compare(sortingArray[i], sortingArray[i + 1]) == -1)
                    {
                        SortHelper.Swap(ref sortingArray[i], ref sortingArray[i + 1]);
                        swap = true;
                    }
                }

                --length;
            }
            while (swap);
        }
    }
}
