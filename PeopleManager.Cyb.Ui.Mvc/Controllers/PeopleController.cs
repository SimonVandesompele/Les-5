using Microsoft.AspNetCore.Mvc;
using PeopleManager.Cyb.Ui.Mvc.Core;
using PeopleManager.Cyb.Ui.Mvc.Models;

namespace PeopleManager.Cyb.Ui.Mvc.Controllers
{
    public class PeopleController : Controller
    {
        private readonly Database _database;

        public PeopleController(Database database)
        {
            _database = database;
        }

        public IActionResult Index()
        {
            var people = _database.People;
            return View(people);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person person)
        {
            person.Id = GetNextId();

            _database.People.Add(person);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = _database.People.FirstOrDefault(p => p.Id == id);
            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Person person)
        {
            var dbPerson = _database.People.FirstOrDefault(p => p.Id == person.Id);

            if (dbPerson is null)
            {
                return RedirectToAction("Index");
            }

            dbPerson.FirstName = person.FirstName;
            dbPerson.LastName = person.LastName;
            dbPerson.Email = person.Email;

            return RedirectToAction("Index");
        }

        private int GetNextId()
        {
            var maxId = _database.People.Max(p => p.Id);
            maxId++;
            return maxId;
        }
    }
}
