using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using viewModel.Models;

namespace viewModel.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        Message TheMessage = new() { TheMessage = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Est voluptatem fugit ipsa dolores eos enim iusto quibusdam dolore quaerat repellat." };
        return View("Index", TheMessage);
    }

    [HttpGet("numbers")]
    public IActionResult Numbers()
    {
        // created list here in controllers
        List<int> Numbers = new() { 1, 3, 4, 5, 5 };
        // used array of numbers from models (Number.cs)
        Number ArrNumber = new();

        return View("Numbers", ArrNumber);
        // return View("Numbers", Numbers);
    }


    [HttpGet("user")]
    public IActionResult User()
    {
        User Neil = new() { FirstName = "Neil", LastName = "Gaiman" };

        return View(Neil);
    }



    [HttpGet("users")]
    public IActionResult Users()
    {
        List<User> UserList = new();
        User Neil = new() { FirstName = "Neil", LastName = "Gaiman" };
        User Terry = new() { FirstName = "Terry", LastName = "Pratchet" };
        User Jane = new() { FirstName = "Jane", LastName = "Austin" };
        User Stephen = new() { FirstName = "Stephen", LastName = "King" };
        User Mary = new() { FirstName = "Mary", LastName = "Shelly" };
        UserList.Add(Neil);
        UserList.Add(Terry);
        UserList.Add(Jane);
        UserList.Add(Stephen);
        UserList.Add(Mary);



        return View(UserList);
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
