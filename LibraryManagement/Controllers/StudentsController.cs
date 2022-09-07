using LibraryManagement.BusinessRepository.Contracts;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentBusiness studentBusiness;

        public StudentsController(IStudentBusiness _studentBusiness)
        {
            studentBusiness = _studentBusiness;
        }
        public IActionResult GetAllStudents()
        {
            return View(studentBusiness.GetAllStudents());
        }
        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            studentBusiness.CreateStudent(student);
            return RedirectToAction("GetAllStudents");
        }

        public IActionResult EditStudentDetails(int rollno, int std, char div)
        {
            Student student = studentBusiness.GetStudentById(rollno, std, div);
            return View(student);
        }
        [HttpPost]
        public IActionResult EditStudentDetails(Student student)
        {
            studentBusiness.EditStudentDetails(student);
            return RedirectToAction("GetAllStudents");
        }

    }
}
