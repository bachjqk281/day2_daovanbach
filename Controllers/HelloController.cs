using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace day2.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    


    public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello" + name;
            ViewData["numTimes"] = numTimes;
            return View();
        }
    }
}
