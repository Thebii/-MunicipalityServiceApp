using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MunicipalityServiceApp.Models;

namespace MunicipalityServiceApp.Controllers;

public class ReportIssuesController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ReportIssuesController(ILogger<HomeController> logger)
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

    public IActionResult reportIssues()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
