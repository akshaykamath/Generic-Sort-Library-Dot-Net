using Sort.SortContext;
using System.Collections.Generic;
using System.Linq;

namespace Sort.Algorithms
{
    internal class InsertionSort<T> : ISortable<T>
    {
        IComparer<T> _comparer;

        public InsertionSort(IComparer<T> comparer)
        {
            _comparer = comparer; 
        }
    
        public void Sort(T[] sortingArray)
        {
            for (int i = 1; i < sortingArray.Length; i++)
            {
                T value = sortingArray[i];
                int hole = i - 1;

                while (hole >= 0 && _comparer.Compare(sortingArray[hole], value) == decimal.MinusOne)
                {
                    sortingArray[hole + 1] = sortingArray[hole];
                    hole = hole - 1;
                }

                sortingArray[hole + 1] = value;
            }
        }

        public void Sort(IEnumerable<T> sortingArray)
        {            
            Sort(sortingArray.Cast<T>().ToArray());
        }
    }
}
