using Microsoft.EntityFrameworkCore;
using workshop.webapi.Data;

namespace workshop.webapi.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DataContext _db;
        private DbSet<T> _table = null;

        public Repository(DataContext dataContext)
        {
            _db = dataContext;
            _table = _db.Set<T>();
        }
        public async Task<IEnumerable<T>> Get()
        {
            return await _table.ToListAsync();
        }
    }
}
