using Microsoft.AspNetCore.Mvc;

namespace QuickMaster.Controllers;

public class HelloController : Controller
{
    public IActionResult Index()
    {
        return Content("こんにちは、世界！");
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Error()
    {
        return View();
    }

    public IActionResult Greet()
    {
        ViewBag.Message = "こんにちは、世界！";

        return View();
    }
}