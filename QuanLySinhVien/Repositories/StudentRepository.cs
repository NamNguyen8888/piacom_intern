using System.Data;
using Dapper;
using QuanLySinhVien.Context;
using QuanLySinhVien.Domains.Entities;
using QuanLySinhVien.Repositories.Interfaces;

namespace QuanLySinhVien.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly DapperContext _context;

    public StudentRepository(DapperContext context)
    {
        _context = context;
    }
    public async Task<bool> Add(Majors majors)
    {
        using var conn = _context.CreateConnection();
        string sql = @"Insert Into dbo.Majors 
                      Values (@MajorsCode, @MajorsName, @Status, @CreatedAt, @CreatedBy)";
        var param = new DynamicParameters();
        param.Add("MajorsCode", majors.MajorsCode, DbType.String);
        param.Add("MajorsName", majors.MajorsName, DbType.String);
        param.Add("Status", 1, DbType.Int32);
        param.Add("CreatedAt", DateTime.Now, DbType.DateTime);
        param.Add("CreatedBy", 1, DbType.Int32);
        var result = await conn.ExecuteAsync(sql, param);
        return result > 0;
    }

    public async Task<IEnumerable<Majors>> GetAll()
    {
        using var conn = _context.CreateConnection();
        string sql = "Select * From dbo.Majors";
        return await conn.QueryAsync<Majors>(sql);
    }


}