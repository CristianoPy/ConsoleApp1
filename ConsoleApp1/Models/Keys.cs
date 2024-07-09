using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Keys
    {

        //• Id(int)
        //• Cod de acces : Guid unic.

        public int Id { get; set; }
        public Guid Code { get; set; }
        public int VehicleId { get; set; }
    }
}
