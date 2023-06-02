using Microsoft.AspNetCore.Mvc;

namespace WebApplicationmvc.Controllers
{
    public class NewController : Controller
    {
        [HttpGet]
        public IActionResult Addnew() 
        {
            return View();
        }
    }
}
