using Microsoft.AspNetCore.Mvc;

namespace project1_structure_mvc.controllrs
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Privacy()
        //{
        //    return View();
        //}
        //public IActionResult AboutAs() 
        //{ 
        //    return View();
        //}

    }
}
