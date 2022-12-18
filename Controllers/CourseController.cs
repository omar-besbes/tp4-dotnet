using Microsoft.AspNetCore.Mvc;

namespace tp4_dotnet.Controllers;

[Route("Courses")]
public class CourseController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}