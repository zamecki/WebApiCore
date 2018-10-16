using System;
using System.Collections.Generic;
using System.Text;

namespace WebAplicationCore.Repository.Repository
{
    public interface IRepository<TEntity, U> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(U id);
        long Add(TEntity b);
        long Update(U id, TEntity b);
        long Delete(U id);
    }
}
