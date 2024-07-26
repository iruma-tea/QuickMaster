using Microsoft.AspNetCore.Mvc;
using QuickMaster.Models;

namespace QuickMaster.Controllers;

public class HelloController : Controller
{
    private readonly MyContext _context;
    public HelloController(MyContext context)
    {
        this._context = context;
    }
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

    public IActionResult List()
    {
        return View(this._context.Book);
    }
}