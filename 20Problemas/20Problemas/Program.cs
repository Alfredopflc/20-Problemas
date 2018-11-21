using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Problemas
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Hasta ahora realizados el 4,5,6,8
            int opc = 0;            
            Opc O = new Opc();

            Console.Write("Ingrese numero del problema \nR = "); //Menu
            opc = int.Parse(Console.ReadLine());

            O.Opcion(opc);
            Console.ReadKey();
        }
    }
}
