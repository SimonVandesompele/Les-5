using PeopleManager.Cyb.Ui.Mvc.Models;

namespace PeopleManager.Cyb.Ui.Mvc.Core
{
    public class Database
    {
        public IList<Person> People { get; set; } = new List<Person>();

        public void Seed()
        {
            People = new List<Person>
            {
                new Person { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" },
                new Person { Id = 2, FirstName = "Jane", LastName = "Smith", Email = null },
                new Person { Id = 3, FirstName = "Bob", LastName = "Johnson", Email = "bob.j@example.com" },
                new Person { Id = 4, FirstName = "Alice", LastName = "Brown", Email = "alice.b@example.com" },
                new Person { Id = 5, FirstName = "Eva", LastName = "Wilson", Email = null },
                new Person { Id = 6, FirstName = "Michael", LastName = "Clark", Email = "michael.c@example.com" },
                new Person { Id = 7, FirstName = "Olivia", LastName = "Taylor", Email = "olivia.t@example.com" },
                new Person { Id = 8, FirstName = "Daniel", LastName = "Anderson", Email = null },
                new Person { Id = 9, FirstName = "Sophia", LastName = "Lee", Email = "sophia.l@example.com" },
                new Person { Id = 10, FirstName = "David", LastName = "Davis", Email = null }
            };
        }
    }
}
