using Microsoft.AspNetCore.Mvc;

namespace PeopleApp.Controllers
{
    public class BlazorController : Controller
    {
        public IActionResult Index()
        {
            return View("_BlazorServer_Host");
        }
    }
}
