using SortingLib.Algorithms;
using SortingLib.SortContext;
using System.Collections.Generic;

namespace SortingLib
{
    /// <summary>
    /// Factory that returns the sorting strategy class instance.
    /// </summary>
    public class SortStrategyFactory
    {
        private static readonly SortStrategyFactory _instance = new SortStrategyFactory();

        private SortStrategyFactory()
        {
        }

        public static SortStrategyFactory Instance
        {
            get { return _instance; }
        }

        public ISortable<T> GetSortStrategy<T>(SortStrategy sortStrategy, IComparer<T> comparer, IList<T> sortArray)
        {
            ISortable<T> sorter = null;

            switch (sortStrategy)
            {
                case SortStrategy.BubbleSort:
                    sorter = new BubbleSort<T>(comparer, sortArray);
                    break;
                case SortStrategy.InsertionSort:
                    sorter = new InsertionSort<T>(comparer, sortArray);
                    break;
                case SortStrategy.SelectionSort:
                    sorter = new SelectionSort<T>(comparer, sortArray);
                    break;
                case SortStrategy.HeapSort:
                    sorter = new HeapSort<T>(comparer, sortArray);
                    break;
                default:
                    sorter = new HeapSort<T>(comparer, sortArray);
                    break;
            }

            return sorter;
        }
    }
}
