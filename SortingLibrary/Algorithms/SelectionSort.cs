using SortingLib.SortContext;
using System.Collections.Generic;

namespace SortingLib.Algorithms
{
    public class SelectionSort<T> : ISortable<T>
    {
        IComparer<T> _comparer;

        public SelectionSort(IComparer<T> comparer, IList<T> sortingArray)
        {
            _comparer = comparer;
            SortingArray = sortingArray;
        }

        public IList<T> SortingArray
        {
            get;
            set;
        }
        
        public void Sort()
        {
            for (int count = 0; count < SortingArray.Count; count++)
            {
                int lowest = count;
                for (int i = count + 1; i < SortingArray.Count; i++)
                {
                    if (_comparer.Compare(SortingArray[i], SortingArray[lowest]) == 1)
                    {
                        lowest = i;
                    }
                }

                SortingArray.SwapItemsAtIndices(lowest, count);
            }
        }
    }
}
