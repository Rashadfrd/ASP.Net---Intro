using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student std1 = new Student { Name = "Rəşad", Surname = "Fərhadzadə", Age = 22 };
            Student std2 = new Student { Name = "Rauf", Surname = "Fərhadzadə", Age = 19 };
            Student std3 = new Student { Name = "Yunis", Surname = "Məmmədov", Age = 22 };

            List<Student> students = new List<Student>();
            students.Add(std1);
            students.Add(std2);
            students.Add(std3);
            return View(students);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
