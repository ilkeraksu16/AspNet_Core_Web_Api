using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        /*
         Aşağıdaki Where methodu IQueryable tanımlandı çünkü bu methodla gelen data üzerinde order by yapılabilir ve bu aşamaya kadar Db üzerinde sorgumuz henüz executer edilmedi, ne zaman toList deriz ondan sonra execute edilir. Bu sebeple methodumuz Async değil. Örnek kullanım 
            productRepository.where(x=>x.id>5).OrderBy.ToListAsync();
         */

        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
