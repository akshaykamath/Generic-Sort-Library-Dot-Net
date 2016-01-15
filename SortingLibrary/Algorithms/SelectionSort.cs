using Sort.SortContext;
using System.Collections.Generic;
using System;

namespace Sort.Algorithms
{
    internal class SelectionSort<T> : ISortable<T>
    {
        IComparer<T> _comparer;

        public SelectionSort(IComparer<T> comparer, T[] sortingArray)
        {
            _comparer = comparer;
            SortingArray = sortingArray;
        }

        public T[] SortingArray
        {
            get;
            set;
        }
        
        public void Sort()
        {
            //int count = 0;
            for (int count = 0; count < SortingArray.Length; count++)
            {
                int lowest = count;
                for (int i = count + 1; i < SortingArray.Length; i++)
                {
                    if (_comparer.Compare(SortingArray[i], SortingArray[lowest]) == 1)
                    {
                        lowest = i;
                    }
                }

                SortHelper.Swap(ref SortingArray[lowest], ref SortingArray[count]);
            }
        }
    }
}
