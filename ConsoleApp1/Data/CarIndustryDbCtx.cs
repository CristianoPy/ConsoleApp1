using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    internal class CarIndustryDbCtx : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Manual> Manuals { get; set; }
        public DbSet<Keys> Keys { get; set; }


        public CarIndustryDbCtx()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\C#\Curso\C#7\Lab 18\ConsoleApp1\ConsoleApp1\L18.mdf"";Integrated Security=True");

        }

        public Vehicle AddVehice(Vehicle vehicle)
        {
            Add(vehicle);
            SaveChanges();
            return vehicle;
        }
       
    }
}
