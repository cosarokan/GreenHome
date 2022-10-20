using System;
using System.Collections.Generic;
namespace BusinessLayer.Interfaces
{
    public interface ISelectableRepository<T> : IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetByID(object ID);
        List<T> GetAll(Func<T, bool> whereCondition);
    }
}
