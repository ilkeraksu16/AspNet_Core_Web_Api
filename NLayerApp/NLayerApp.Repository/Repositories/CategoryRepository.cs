using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Models;
using NLayerApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId)
        {
            // SingleOrDefault ile Where şartını sağlayan birden fazla kayıt varsa hata fırlatır.
            //Seçilen kategorinin productslarını getirir.
            return await _context.Categories.Include(x => x.Products).Where(x => x.Id == categoryId).SingleOrDefaultAsync();
        }
    }
}
