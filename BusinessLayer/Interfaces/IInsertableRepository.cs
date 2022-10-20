using System.Collections.Generic;
namespace BusinessLayer.Interfaces
{
    public interface IInsertableRepository<T> : IRepository<T> where T : class
    {
        T Add(T item);
        List<T> AddRange(List<T> items);
    }
}
