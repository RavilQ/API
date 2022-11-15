using Microsoft.AspNetCore.Mvc;

namespace ASP_2._0_.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
