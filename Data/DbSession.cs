using System.Data;

using Microsoft.Data.SqlClient;

namespace Revisao.Data;

public class DbSession : IDisposable

{

    public IDbConnection Connection { get; }

    public DbSession(IConfiguration configuration)

    {

        Connection = new SqlConnection(configuration

        .GetConnectionString("ConnectionStrings"));

        Connection.Open();

    }

    public void Dispose() => Connection?.Dispose();

}