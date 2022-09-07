using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.BusinessRepository.Contracts
{
    public interface IStudentBusiness
    {
        IEnumerable<Student> GetAllStudents();
        Student CreateStudent(Student student);
        Student GetStudentById(int rollno, int std, char div);
        Student EditStudentDetails(Student student);
    }
}
