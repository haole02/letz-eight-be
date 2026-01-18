using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Wrkom.ApplicationCore.Entities;
using Wrkom.WebUi.Models;
using Wrkom.WebUi.Models.ViewModels;

namespace Wrkom.WebUi.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var user = new User("haole", "haole123");
        var vm = new UserViewModel(user);
        return View(vm);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
