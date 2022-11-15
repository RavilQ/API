

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_2._0_.Controllers
{
    public class StudentController:Controller
    {
        public IActionResult detail(int id)
        {

            List<string> students = new List<string>
            {
                "Ravil Quliyev",
                "Tahir Tahirli",
                "Seymur Fahradov",
                "Semender Semenderov",
                "Sabrina Eliyeva",
                "Ali Pashayev"
            };

            ViewBag.student = students;

            ViewBag.id = id;

            return View();
            
           
        }
    }
}
