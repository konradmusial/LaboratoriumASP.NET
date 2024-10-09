using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Kalkulator(Operator op, double? x, double? y)
    {
        //var op = Request.Query["op"];
        //var x = double.Parse(Request.Query["x"]);
        //var y = double.Parse(Request.Query["y"]);
        if (x is null || y is null)
        {
            ViewBag.ErrorMessage = "Niepoprawny format liczby x lub y lub ich brak!";
            return View("KalkulatorError");
        }
        //if (op is null)
        //{
        //    ViewBag.ErrorMessage = "kl;";
        //    return View("KalkulatorError");
        //}
        
        double? result = 0.0d;
        switch (op)
        {
            case Operator.add:
                result = x + y;
                ViewBag.Operator = "+";
                break;
            case Operator.sub:
                result = x - y;
                ViewBag.Operator = "-";
                break;
            case Operator.mul:
                result = x * y;
                ViewBag.Operator = "*";
                break;
            case Operator.div:
                result = x / y;
                ViewBag.Operator = ":";
                break;
            default:
                ViewBag.ErrorMessage = "Nieznany operator!";
                return View("KalkulatorError");
                
        }
        ViewBag.Result = result;
        ViewBag.x = x;
        ViewBag.y = y;
        ViewBag.op = op;
        return View();
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
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
public enum Operator

{
    add, sub, div, mul
}
//zadanie domowe
//napisz metode Age, ktora przyjmuje parametr z data urodzin i wyswietla wiek w latach miesiacach i dniach