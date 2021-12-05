using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using SalesSystem.Domain.Repository;


namespace Repository.Entities
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext dbContext) : base(dbContext) { }
      
    }
}
