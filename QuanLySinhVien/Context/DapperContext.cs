using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien.Context;

public class DapperContext
{
    private readonly string _connectionString;

    public DapperContext(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("SqlConnection") ?? throw new ArgumentException("SqlConnection");
    }

    public IDbConnection CreateConnection()
        => new SqlConnection(_connectionString);
}
