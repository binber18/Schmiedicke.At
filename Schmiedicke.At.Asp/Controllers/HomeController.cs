using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Schmiedicke.At.Asp.ViewModels;
using Schmiedicke.At.Services;

namespace Schmiedicke.At.Asp.Controllers;

[Authorize]
public class HomeController : Controller
{
    private readonly ILinksService _linksService;

    public HomeController(ILinksService linksService)
    {
        _linksService = linksService;
    }
    public async Task<IActionResult> Links()
    {
        if (User.Identity?.Name is null)
            return Unauthorized();
        
        var links = await _linksService.GetAllForUser(User.Identity.Name);
        return View(links);
    }

    public IActionResult UserProperties()
    {
        return View();
    }

    [AllowAnonymous]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}