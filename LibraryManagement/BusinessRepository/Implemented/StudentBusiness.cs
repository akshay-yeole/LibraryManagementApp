using LibraryManagement.BusinessRepository.Contracts;
using LibraryManagement.DataRepository.Contracts;
using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.BusinessRepository.Implemented
{
    public class StudentBusiness : IStudentBusiness
    {
        private readonly IStudentData studentData;

        public StudentBusiness(IStudentData _studentData)
        {
            studentData= _studentData;
        }

        public Student CreateStudent(Student student)
        {
            return studentData.CreateStudent(student);
        }

        public Student EditStudentDetails(Student student)
        {
            return studentData.EditStudentDetails(student);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return studentData.GetAllStudents();
        }

        public Student GetStudentById(int rollno, int std, char div)
        {
            return studentData.GetStudentById(rollno, std, div);
        }
    }
}
