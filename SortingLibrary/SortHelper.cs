using SortingLib.SortContext;
using System.Collections.Generic;

namespace SortingLib
{
    public static class SortHelper
    {
        /// <summary>
        /// Swaps two items in an IList collection.
        /// </summary>        
        public static void SwapItemsAtIndices<T>(this IList<T> list, int index1, int index2)
        {
            var temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The instance on which this extension method is applied.</param>
        /// <param name="strategy">The strategey enum that specifies the algorithm of sort.</param>
        /// <param name="comparer">The comparer for specifying the comparison order.</param>
        public static void Sort<T>(this IList<T> list, SortStrategy strategy, IComparer<T> comparer)
        {
            var sortStrategy = SortStrategyFactory.Instance.GetSortStrategy(strategy, comparer, list);
            var context = new SortStrategyContext<T>(sortStrategy);
            context.InvokeSort();
        }

    }
}
