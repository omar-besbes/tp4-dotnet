using Microsoft.AspNetCore.Mvc;
using tp4_dotnet.Data;

namespace tp4_dotnet.Controllers;

[Route("Courses")]
public class CourseController : Controller
{
    private readonly IUniversityRepository _repository;

    public CourseController(IConfiguration configuration)
    {
        _repository = new UniversityRepository(UniversityContext.Instantiate_UniversityContext(configuration));
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    [Route("{course}")]
    public IActionResult Course(string course)
    {
        var students = _repository.GetStudentsByCourse(course);
        return View(students);
    }
}