using Sort.SortContext;
using System.Collections.Generic;
using System;

namespace Sort.Algorithms
{
    internal class BubbleSort<T>: ISortable<T>
    {
        IComparer<T> _comparer;

        public BubbleSort(IComparer<T> comparer, T[] sortingArray)
        {
            _comparer = comparer;
            SortingArray = sortingArray;
        }

        public T[] SortingArray
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Sort()
        {
            int length = SortingArray.Length;
            bool swap = false;
            do
            {
                swap = false;
                for (int i = 0; i < length - 1; i++)
                {
                    if (_comparer.Compare(SortingArray[i], SortingArray[i + 1]) == -1)
                    {
                        SortHelper.Swap(ref SortingArray[i], ref SortingArray[i + 1]);
                        swap = true;
                    }
                }

                --length;
            }
            while (swap);
        }
    }
}
