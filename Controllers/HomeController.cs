using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentDemo.Models;

namespace StudentDemo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        try
        {
            throw new Exception("Testing this class");
        }
        catch(Exception ex)
        {
            
        }
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
        //test
    }

}
