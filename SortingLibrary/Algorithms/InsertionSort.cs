using Sort.SortContext;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Sort.Algorithms
{
    internal class InsertionSort<T> : ISortable<T>
    {
        IComparer<T> _comparer;

        public InsertionSort(IComparer<T> comparer, T[] sortArray)
        {
            _comparer = comparer;
            SortingArray = sortArray;
        }

        public T[] SortingArray
        {
            get;
            set;
        }

        public void Sort()
        {
            for (int i = 1; i < SortingArray.Length; i++)
            {
                T value = SortingArray[i];
                int hole = i - 1;

                while (hole >= 0 && _comparer.Compare(SortingArray[hole], value) == decimal.MinusOne)
                {
                    SortingArray[hole + 1] = SortingArray[hole];
                    hole = hole - 1;
                }

                SortingArray[hole + 1] = value;
            }
        }

        public void Sort(IEnumerable<T> sortingArray)
        {            
            Sort(sortingArray.Cast<T>().ToArray());
        }
    }
}
