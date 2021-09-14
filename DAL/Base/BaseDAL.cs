using System.Collections.Generic;

namespace EcommerceGoldenRetriever.MVC.DAL.Base
{
    public abstract class BaseDAL<T>
    {
        internal abstract bool Insert(T obj);
        internal abstract bool Delete(int id);
        internal abstract bool Update(T obj);
        internal abstract T GetById(int id);
        internal abstract List<T> GetByExample(T obj);
        internal abstract List<T> GetAll();
    }
}
