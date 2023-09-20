using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFirstProjectWeb.Models;

namespace MyFirstProjectWeb.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        HomeModel home = new HomeModel();

        home.Nome = "Thiago Martines";
        home.Email = "thiaggomartines@gmail.com";

        return View(home);
    }
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Contato()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
