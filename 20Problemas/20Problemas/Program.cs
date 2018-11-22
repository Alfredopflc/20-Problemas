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
            
            int opc = 0, op = 0;            
            Opc O = new Opc();

            do
            {
                Console.Write("Ingrese numero del problema \nR = "); //Menu
                opc = int.Parse(Console.ReadLine());

                O.Opcion(opc);

                Console.WriteLine("Desea iniciar otro programa? \n1 = Si \n2 = No \n R = ");
                op = int.Parse(Console.ReadLine());

            } while (op == 1);

            Console.ReadKey();
        }
    }
}
