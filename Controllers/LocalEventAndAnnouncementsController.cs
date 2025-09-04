using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MunicipalityServiceApp.Models;

namespace MunicipalityServiceApp.Controllers;

public class LocalEventsAndAnnouncementsController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public LocalEventsAndAnnouncementsController(ILogger<HomeController> logger)
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

    public IActionResult LocalEventsAndAnnouncements()
    {
        return View("~/Views/LocalEventsAndAnnouncements/localEventsAndAnnouncements.cshtml");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
