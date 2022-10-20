namespace BusinessLayer.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void MySaveChanges();
    }
}
