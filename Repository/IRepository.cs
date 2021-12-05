using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
  public  interface IRepository<TEntity>
        where TEntity:class
    {

        void Create<T>(T Entity);

        TEntity Read(int id);

        void Delete(int id);

        IEnumerable<TEntity> Read();

    }
}
