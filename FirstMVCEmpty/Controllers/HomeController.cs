using Microsoft.AspNetCore.Mvc;

namespace FirstMVCEmpty.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Azhar hussain is my name.";
        //}
        //public string Name()
        //{
        //    return "This is my name";
        //}
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Name()
        {
            return View();
        }
    }
}
