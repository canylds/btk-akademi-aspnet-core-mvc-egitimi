using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers;

public class EmployeeController : Controller
{
    public IActionResult Index1()
    {
        string message = $"Hi! {DateTime.Now.ToString()}";
        return View("Index1", message);
    }

    public ViewResult Index2()
    {
        var names = new string[]
        {
            "Ahmet",
            "Mehmet",
            "Can"
        };
        
        return View(names);
    }

    public IActionResult Index3()
    {
        var list = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Can",
                Age = 20
            },
            new Employee()
            {
                Id = 2,
                FirstName = "Okan",
                LastName = "Can",
                Age = 30
            },
            new Employee()
            {
                Id = 3,
                FirstName = "Berk",
                LastName = "Can",
                Age = 40
            }
        };

        return View("Index3", list);
    }
}