using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentDetailsDBF.Context;
using StudentDetails.Global_Exception;
using StudentDetailsDBF.Models;
using StudentDetailsDBF.Services.Interfaces;

namespace StudentDetailsDBF.Services
{
    public class StudentService : IStudent
    {
        public StudentContext? _studentContext;

        public StudentService(StudentContext? studentContext)
        {
            _studentContext = studentContext;
        }

        public  async Task<List<Student>> AddStudent(Student student)
        {
            _studentContext.Students.Add(student);
            await _studentContext.SaveChangesAsync();
            return await _studentContext.Students.ToListAsync();
           
        }


        
        public async Task<List<Student>> GetAllStudents()
        {
            var response = await _studentContext.Students.ToListAsync();
            return response;
        }

        public async Task<Student> GetStudentByRollno(int rollno)
        {
         var student=await _studentContext.Students.FindAsync(rollno);
            if (student == null)
            {
                throw new Exception(StudentDetailsException.StudentDetailExceptions[0]);
            }
            return student;
        }

        public async Task<Student> UpdateStudent(int rollno, Student student)
        {
           var rstudent = await _studentContext.Students.FindAsync(rollno);
            if (rstudent == null)
            {
                throw new Exception(StudentDetailsException.StudentDetailExceptions[0]);
            }
                    rstudent.Studname = student.Studname;
                    rstudent.Addr = student.Addr;
                    rstudent.Phno = student.Phno;

            await _studentContext.SaveChangesAsync();
            rstudent = await _studentContext.Students.FindAsync(rollno);

            return rstudent;
        }

        public async Task<List<Student>> DeleteStudent(int rollno) {
            var rstudent = await _studentContext.Students.FindAsync(rollno);
            if (rstudent == null)
            {
                throw new Exception(StudentDetailsException.StudentDetailExceptions[0]);
            }
             _studentContext.Students.Remove(rstudent);
            await _studentContext.SaveChangesAsync();
            var response = await _studentContext.Students.ToListAsync();
            return response;


        }
    }
}
