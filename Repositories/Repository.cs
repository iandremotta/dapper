using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Revisao.Data;

namespace Revisao.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly DbSession _context;

        public Repository(DbSession context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll() => _context.Connection.GetAll<T>();
    }
}