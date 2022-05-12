using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Revisao.Data;
using Revisao.Models;

namespace Revisao.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly DbSession _connection;
        public UserRepository(DbSession connection) : base(connection)
        {
            _connection = connection;
        }
    }
}