using System;
using System.Collections.Generic;
using System.Text;
using appInfraestrutura.Model;
using Microsoft.EntityFrameworkCore;

namespace appInfraestrutura.Database
{
    public class BancoContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=core;User Id=login_core;Password=123456;");
        }

    }
}