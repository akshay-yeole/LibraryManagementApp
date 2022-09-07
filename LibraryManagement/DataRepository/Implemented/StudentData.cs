using LibraryManagement.DataContext;
using LibraryManagement.DataRepository.Contracts;
using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.DataRepository.Implemented
{
    public class StudentData : IStudentData
    {
        private readonly AppDataContext dataContext;

        public StudentData(AppDataContext _dataContext)
        {
            dataContext = _dataContext;
        }

        public Student CreateStudent(Student student)
        {
            dataContext.Students.Add(student);
            dataContext.SaveChanges();
            return student;
        }

        public Student EditStudentDetails(Student student)
        {
            Student founded = dataContext.Students.Where(s => s.Rollno == student.Rollno && s.Std == student.Std && s.Div == student.Div).FirstOrDefault();

            if (founded != null)
            {
                founded.Name = student.Name;
                founded.Address = student.Address;
                dataContext.Students.Update(founded);
                dataContext.SaveChanges();
                return founded;
            }
            return null;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return dataContext.Students.ToList();
        }

        public Student GetStudentById(int rollno, int std, char div)
        {
            Student student = dataContext.Students.Where(r => r.Rollno == rollno && r.Std == std && r.Div == div).FirstOrDefault();
            return student;
        }
    }
}
