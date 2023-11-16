using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers;

public class DepartamentsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}