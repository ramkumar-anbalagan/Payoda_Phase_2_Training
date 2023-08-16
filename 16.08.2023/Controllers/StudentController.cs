using JWTAuth.Models;
using JWTAuth.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IStudent _student;

        public StudentController(IStudent student)
        {
            _student = student;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            var students = await _student.GetAllStudents();
            if (students == null)
            {
                return NotFound();
            }
            else
            {
                return students;
            }

        }
        [HttpGet("{rollno}")]
        public async Task<ActionResult<Student>> GetStudentByRollno(int rollno)
        {
            Student student;
            try
            {
                student = await _student.GetStudentByRollno(rollno);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(student);

        }
        [HttpPost]

        public async Task<ActionResult<Student>> AddStudent(Student student)
        {

            var students = await _student.AddStudent(student);
            return Ok(students);

        }

        [HttpPut]

        public async Task<ActionResult<Student>> UpdateStudent(int rollno, Student student)
        {
            try
            {
                var rstudent = await _student.UpdateStudent(rollno, student);
                return Ok(rstudent);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

        [HttpDelete]
        public async Task<ActionResult<Student>> DeleteStudent(int rollno)
        {

            try
            {
                var student = await _student.DeleteStudent(rollno);
                return Ok(student);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }
    }
}
