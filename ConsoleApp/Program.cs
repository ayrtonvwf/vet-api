using System;
using Model;
using Persistencia;
using Servico;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EFContext();
            context.Database.EnsureCreated();

            var person = new Person() {Name = "Ayrton", IsAdmin = false, Income = 700};
            var personb = new Person() {Name = "Sandro", IsAdmin = true};

            var service = new PersonService();
            
            service.Store(person);
            service.Store(personb);

            var persons = service.All();
            foreach (var person1 in persons)
            {
                Console.WriteLine($"ID: {person1.PersonID}");
                Console.WriteLine($"Nome: {person1.Name}");
                Console.WriteLine($"Admin: {person1.IsAdmin}");
                Console.WriteLine($"Income: {person1.Income}");
                Console.WriteLine();
            }
        }
    }
}