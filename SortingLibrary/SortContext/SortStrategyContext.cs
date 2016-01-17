namespace SortingLib.SortContext
{
    public class SortStrategyContext<T>
    {
        private ISortable<T> _sortStrategy;

        public SortStrategyContext(ISortable<T> sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void InvokeSort()
        {
            _sortStrategy.Sort();
        }       
    }
}
