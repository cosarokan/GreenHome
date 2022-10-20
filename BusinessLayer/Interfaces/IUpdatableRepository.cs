namespace BusinessLayer.Interfaces
{
    public interface IUpdatableRepository<T> : IRepository<T> where T : class
    {
        void Update(T item);
    }
}
