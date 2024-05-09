using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webAPI.Models;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        private readonly SchoolContext _context;

        public GradesController(SchoolContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllGrades()
        {
        var studentsInGrade = _context.Students.Where(s => s.GradeId == 1000).ToList();

        return Ok(studentsInGrade);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Grade>>> GetGradeById(int id)
        {
            var grade = _context.Grades.Where(x => x.GradeId == id);
            return Ok(_context.Grades);
        }

        [HttpPost]
        public async Task<ActionResult<List<Grade>>> AddGrade(Grade grade)
        {
            _context.Grades.Add(grade);
            _context.SaveChanges();
            return Ok(_context.Grades);
        }
    }
}
