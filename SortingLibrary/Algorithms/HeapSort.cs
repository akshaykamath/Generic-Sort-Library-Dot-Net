using SortingLib.SortContext;
using System.Collections.Generic;

namespace SortingLib.Algorithms
{
    public class HeapSort<T> : ISortable<T>
    {
        private IComparer<T> _comparer;
        private int _heapSize;

        public IList<T> SortingArray
        {
            get;
            set;
        }

        public HeapSort(IComparer<T> comparer, IList<T> sortingArray)
        {
            _comparer = comparer;
            SortingArray = sortingArray;
            BuildHeap();
        }

        private int Left(int index)
        {
            if (index == 0)
            {
                return 1;
            }

            return 2 * index;
        }

        private int Right(int index)
        {
            return Left(index) + 1;
        }

        private int Parent(int index)
        {
            return index / 2;
        }

        private void Heapify(int index)
        {
            int left = Left(index);
            int right = Right(index);
            int dominatingIndex = index;

            if (left < _heapSize && _comparer.Compare(SortingArray[left], SortingArray[index]) == -1)
            {
                dominatingIndex = left;
            }

            if (right < _heapSize && _comparer.Compare(SortingArray[right], SortingArray[dominatingIndex]) == -1)
            {
                dominatingIndex = right;
            }

            if (dominatingIndex != index)
            {
                SortingArray.SwapItemsAtIndices(index, dominatingIndex);                
                Heapify(dominatingIndex);
            }
        }

        private void BuildHeap()
        {
            _heapSize = SortingArray.Count;
            for (int i = SortingArray.Count / 2; i >= 0; i--)
            {
                Heapify(i);
            }
        }

        public void Sort()
        {
            for (int i = SortingArray.Count - 1; i > 0; i--)
            {
                SortingArray.SwapItemsAtIndices(0, i);                
                _heapSize = _heapSize - 1;
                Heapify(0);
            }
        }
    }
}
