using ConsoleApp1.Data;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;


//Seed();

static void Seed()
{
    using var ctx = new CarIndustryDbCtx();

    var ford = new Manufacturer
    {
        Name = "Ford",
        Adress = "USA"
    };
    ctx.Add(ford);

    var focus = new Vehicle
    {
        Name = "Focus",
        Manufacturer = ford,
        Manual = new Manual {Cc = 1100, Year = 2021, Rn = Guid.NewGuid().ToString() }
    };

    var ka  = new Vehicle
    {
        Name = "Ka",
        Manufacturer = ford,
        Manual = new Manual {Cc = 1000, Year = 2018, Rn = Guid.NewGuid().ToString() }
    };

    ctx.Add(focus);
    ctx.Add(ka);

    ctx.SaveChanges();
}
