using QuanLySinhVien.Domains.Entities;

namespace QuanLySinhVien.Repositories.Interfaces;

public interface IStudentRepository
{
    Task<bool> Add(Majors majors);
    Task<IEnumerable<Majors>> GetAll();
    Majors GetMajors(); 
}