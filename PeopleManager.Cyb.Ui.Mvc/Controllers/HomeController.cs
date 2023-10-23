using Microsoft.AspNetCore.Mvc;
using PeopleManager.Cyb.Ui.Mvc.Models;
using System.Diagnostics;
using PeopleManager.Cyb.Ui.Mvc.Core;

namespace PeopleManager.Cyb.Ui.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly Database _database;

        public HomeController(Database database)
        {
            _database = database;
        }

        public IActionResult Index()
        {
            var people = _database.People;
            return View(people);
        }

        public IActionResult Details(int id)
        {
            var person = _database.People.SingleOrDefault(p => p.Id == id);
            if (person is null)
            {
                return RedirectToAction("Index");
            }
            return View(person);
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
}