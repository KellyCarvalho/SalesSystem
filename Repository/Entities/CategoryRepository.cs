using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Interfaces;
using SalesSystem.Domain.Repository;


namespace Repository.Entities
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext) { 
        
        }
      
    }
}
