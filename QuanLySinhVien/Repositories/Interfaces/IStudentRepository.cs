using QuanLySinhVien.Domains.Entities;
using QuanLySinhVien.Model;

namespace QuanLySinhVien.Repositories.Interfaces;

public interface IStudentRepository
{
    Task<bool> Add(Majors majors);
    Task<Response<IEnumerable<Majors>>> GetAll();
}