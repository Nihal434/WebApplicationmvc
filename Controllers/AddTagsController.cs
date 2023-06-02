using Microsoft.AspNetCore.Mvc;

namespace WebApplicationmvc.Controllers
{
    public class AddTagsController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
