namespace BusinessLayer.Interfaces
{
    public interface IDeletableRepository<T> : IRepository<T> where T : class
    {
        T Delete(T item);
    }
}
