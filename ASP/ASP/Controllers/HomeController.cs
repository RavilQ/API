using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ASP.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            ViewResult vr = new ViewResult();
            vr.ViewName = "Index";
            return vr;
        }

        public ViewResult About()
        {
            ViewResult vr = new ViewResult();
            vr.ViewName = "About";
            return vr;
        }



        public ContentResult Content(string name, string surname, int id)
        {
            ContentResult cr = new ContentResult();
            cr.Content = $"Fullname:{id} - {name} {surname}";

            return cr;
        }

        public ViewResult Contact()
        {
            return View();
        }

        public ViewResult Faq()
        {
            return View();
        }

        public JsonResult Student()
        {
            var obj = new { name = "Ravil", surname = "Quliyev" };
            JsonResult jr = new JsonResult(obj);
            return jr;
        }


    }
}
