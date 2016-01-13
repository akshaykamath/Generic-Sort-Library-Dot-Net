namespace Sort.SortContext
{
    public class SortStrategyContext<T>
    {
        private ISortable<T> _sortStrategy;

        public SortStrategyContext(ISortable<T> sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void InvokeSort(T[] sortingNumber)
        {
            _sortStrategy.Sort(sortingNumber);
        }       
    }
}
