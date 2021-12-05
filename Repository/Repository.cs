using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using SalesSystem.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public abstract class Repository<TEntity> : DbContext, IRepository<TEntity>
        where TEntity : class, new()
    {
        DbContext Db;
        DbSet<TEntity> DbContextSet;

        public Repository(DbContext dbContext)
        {
            Db = dbContext;
            DbContextSet = Db.Set<TEntity>();

        }
        public void Create<T>(T Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity Read(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Read()
        {
           return DbContextSet.AsNoTracking().ToList();

        }
    }
}
