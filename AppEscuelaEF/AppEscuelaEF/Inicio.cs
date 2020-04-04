using System;
using AppEscuelaEF.Context;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuelaEF
{
    class Inicio
    {
        static void Main(string[] args)
        {
            EscuelaDbContext escuelaContext = new EscuelaDbContext();
            Console.WriteLine("Inicio Pragrama");
            Console.ReadLine();
        }
    }
}
