using System.Collections.Generic;

namespace SortingLib.SortContext
{
    public interface ISortable<T>
    {
        IList<T> SortingArray { get; set; }
        void Sort();        
    }
}
