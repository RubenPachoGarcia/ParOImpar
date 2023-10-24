using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOImpar.Servicios
{
    internal class MenuImplemetacion:MenuInterfaz
    {
        public int pedirNum()
        {        
            int n1;
            Console.WriteLine("Introduzca un numero: ");
            n1=Convert.ToInt32(Console.ReadLine());
            return n1;
       
        }

    }
}
