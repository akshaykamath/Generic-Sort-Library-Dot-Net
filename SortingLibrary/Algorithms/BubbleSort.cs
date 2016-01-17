using SortingLib.SortContext;
using System.Collections.Generic;

namespace SortingLib.Algorithms
{
    public class BubbleSort<T>: ISortable<T>
    {
        IComparer<T> _comparer;

        public BubbleSort(IComparer<T> comparer, IList<T> sortingArray)
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
            int length = SortingArray.Count;
            bool swap = false;
            do
            {
                swap = false;
                for (int i = 0; i < length - 1; i++)
                {
                    if (_comparer.Compare(SortingArray[i], SortingArray[i + 1]) == -1)
                    {
                        SortingArray.SwapItemsAtIndices(i, i + 1);
                        swap = true;
                    }
                }

                --length;
            }
            while (swap);
        }
    }
}
