using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MunicipalityServiceApp.Models;

namespace MunicipalityServiceApp.Controllers;

public class LocalEventAndAnnouncementsController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public LocalEventAndAnnouncementsController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult LocalEventAndAnnouncements()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
