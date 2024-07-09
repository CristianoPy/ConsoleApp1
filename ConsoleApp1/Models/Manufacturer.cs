using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Manufacturer
    {
        //• Id:int
        //• Nume
        //• Adresa:string
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Vehicle> Cars { get; set; } = [];
    }
}
