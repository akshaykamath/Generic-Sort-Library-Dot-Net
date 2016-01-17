using SortingLib.SortContext;
using System.Collections.Generic;
using System.Linq;

namespace SortingLib.Algorithms
{
    public class InsertionSort<T> : ISortable<T>
    {
        IComparer<T> _comparer;

        public InsertionSort(IComparer<T> comparer, IList<T> sortArray)
        {
            _comparer = comparer;
            SortingArray = sortArray;
        }

        public IList<T> SortingArray
        {
            get;
            set;
        }

        public void Sort()
        {
            for (int i = 1; i < SortingArray.Count; i++)
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
