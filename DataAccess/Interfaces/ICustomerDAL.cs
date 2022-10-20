using BusinessLayer.Interfaces;
using EntityLayer.Models;
namespace DataAccess.Interfaces
{
    public interface ICustomerDAL : ISelectableRepository<Customer>
    {
    }
}
