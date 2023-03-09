using Microsoft.AspNetCore.Mvc;
using QuanLySinhVien.Domains.Entities;
using QuanLySinhVien.Repositories.Interfaces;

namespace QuanLySinhVien.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _repo;
        private readonly ILogger<StudentController> _logger;

        public StudentController(IStudentRepository repo, ILogger<StudentController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        // TODO: Viết 1 api Sửa httpMethod = PUT, 1 api xóa httpMethod = DELETE, 1 api GetById GET

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var response = await _repo.GetAll();
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogDebug(ex.Message);
                _logger.LogDebug(ex.StackTrace);
                return NotFound();
            }
        }
        [HttpGet("Test")]
        public IActionResult Test()
        {
            try
            {
                var response =  _repo.GetMajors();
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogDebug(ex.Message);
                _logger.LogDebug(ex.StackTrace);
                return NotFound();
            }
        }


        [HttpPost]
        public async Task<IActionResult> Post(Majors majors)
        {
            try
            {
                var response = await _repo.Add(majors);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogDebug(ex.Message);
                _logger.LogDebug(ex.StackTrace);
                return NotFound();
            }
        }
    }
}