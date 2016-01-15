using Sort.SortContext;
using System.Collections.Generic;

namespace Sort.Algorithms
{
    internal class HeapSort<T> : ISortable<T>
    {
        private IComparer<T> _comparer;
        private int _heapSize;

        public T[] SortingArray
        {
            get; set;
        }

        public HeapSort(IComparer<T> comparer, T[] sortingArray)
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
                SortHelper.Swap(ref SortingArray[index], ref SortingArray[dominatingIndex]);
                Heapify(dominatingIndex);
            }
        }

        private void BuildHeap()
        {
            _heapSize = SortingArray.Length;
            for (int i = SortingArray.Length / 2; i >= 0; i--)
            {
                Heapify(i);
            }
        }

        public void Sort()
        {
            for (int i = SortingArray.Length - 1; i > 0; i--)
            {
                SortHelper.Swap(ref SortingArray[0], ref SortingArray[i]);
                _heapSize = _heapSize - 1;
                Heapify(0);
            }
        }
    }
}
