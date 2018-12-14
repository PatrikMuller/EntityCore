using System;
using System.Collections.Generic;
using appInfraestrutura.Database;
using appInfraestrutura.Model;

namespace appConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BancoContext())
            {
                context.Database.EnsureCreated();
            }

            Console.WriteLine("Database!");

            Console.ReadKey();

            using (var context = new BancoContext())
            {
                var author = new Author
                {
                    FirstName = "William",
                    LastName = "Shakespeare",
                    Books = new List<Book>
                    {
                        new Book { Title = "Hamlet"},
                        new Book { Title = "Othello" },
                        new Book { Title = "MacBeth" }
                    }
                };
                context.Add(author);
                context.SaveChanges();
            }

            Console.WriteLine("Save!");

            Console.ReadKey();

            using (var context = new BancoContext())
            {
                foreach (var book in context.Books)
                {
                    Console.WriteLine(book.Title);
                }
            }

            Console.WriteLine("Lista!");

            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }
}
