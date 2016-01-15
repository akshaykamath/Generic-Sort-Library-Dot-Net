
namespace Sort.SortContext
{
    public interface ISortable<T>
    {
        T[] SortingArray { get; set; }
        void Sort();        
    }
}
