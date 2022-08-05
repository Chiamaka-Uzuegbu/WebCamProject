using Microsoft.AspNetCore.Mvc;

namespace WebCamProject.Controllers
{
    public class CamController : Controller
    {
        public IActionResult Capture()
        {
            return View();
        }
    }
}
