using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP.Controllers
{
    public class ProductController:Controller
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
        }



        public ViewResult detail(int id, string name,string surname)
        {
          
            TempData["id"] = 7;

          

            Product Pr = new Product
            {
                Id = id,
                Name = name,
                Surname = surname
            };

            ViewData["Product"] = Pr;

            return View();
        }

        public IActionResult index()
        {
            List<string> heroes = new List<string>
            {
                "Thor",
                "Hulk",
                "Toni"
            };

            ViewBag.heroes = heroes; 

            return View();
        }

    }
}
