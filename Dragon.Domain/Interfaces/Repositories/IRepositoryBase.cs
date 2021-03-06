using System;
using System.Collections.Generic;
using System.Text;

namespace Dragon.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Delete(TEntity Id);
        void Dispose();
    }
}
