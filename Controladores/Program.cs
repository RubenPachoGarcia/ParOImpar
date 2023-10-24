using ParOImpar.Servicios;

namespace CuadradoNumero
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n1;

            MenuInterfaz mi=new MenuImplemetacion();
            n1 = mi.pedirNum();

            if(n1%2==0 )
            {
                Console.WriteLine("El numero " + n1 + " es par");
            }
            else
            {
                Console.WriteLine("El numero " + n1 + " es impar");
            }
        }
    }
}
