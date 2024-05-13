using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Unicam.Paradigmi.Models.Entities;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Unicam.Paradigmi.Models.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<Libro> Libro { get; set; }
        public DbSet<Utente> Utente { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public MyDbContext() : base()
        {
            
        }
        public MyDbContext(DbContextOptions<MyDbContext> config) : base(config)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           /* optionsBuilder.UseSqlServer("Server=localhost;Database=UnicamParadigmiWebApi;User Id=admin;Password=admin;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);*/
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
            base.OnModelCreating(modelBuilder);
            */
        }

    }
}
