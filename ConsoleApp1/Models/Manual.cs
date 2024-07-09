using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Manual
    {
        //• Id:int
        //• Capacitate cilindrica :int
        //• An de fabricatie :int
        //• Serie de sasiu: string

        public int Id { get; set; }
        public int Cc { get; set; }
        public int Year { get; set; }
        public string Rn { get; set; }
        public int VehicleId { get; set; }

    }
}
