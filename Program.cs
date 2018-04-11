using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string monto;
            double itbis;
            double total;
            string pago;
            double devuelta;
           

                Console.WriteLine("El monto del articulo es = ");
                monto = Console.ReadLine();
                itbis = int.Parse(monto) * 0.18;
                Console.WriteLine("Su ITBIS es ");
                Console.WriteLine(itbis);
                total = int.Parse(monto) + itbis;
                Console.WriteLine("------------------------------");
                Console.WriteLine("El total a pagar es de... ");
                Console.WriteLine(total);
                Console.WriteLine("Digite el monto a pagar = ");
                pago = Console.ReadLine();
                devuelta = int.Parse(pago) - total;

                if (int.Parse(pago) >= total)
                {
                    Console.WriteLine("Tienes que devolver: ");
                    Console.WriteLine(devuelta);
                    Console.WriteLine("GRACIAS POR SU COMPRA, VUELVA PRONTO!");

                }
                else
                {
                    Console.WriteLine("Total invalido, vuelva a intentarlo...");

                }

           

           

            
            Console.ReadKey();

            
        }
    }
}
