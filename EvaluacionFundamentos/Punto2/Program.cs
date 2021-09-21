using System;

namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            string continente = PedirContinente();
            int cantidadDias = PedirDias();

            int precio = cantidadDias * 100;

            string pago = PedirMetodoPago();
            float precioFinal = Descuento(continente, pago, precio);
            Console.WriteLine("Su precio final es {0}", precioFinal);

        }
        static string PedirContinente()
        {
            string continente;
            bool flag;
            do
            {
                Console.WriteLine("Ingrese el continente de destino \namerica \nafrica \nasia \neuropa \noceania");
               
                continente = Console.ReadLine();
                
                if (continente == "america" || continente == "africa" || continente == "asia" || continente == "europa" || continente == "oceania")
                {
                    flag = false;
                }
                else { Console.WriteLine("Ingrese un continente valido"); flag = true; }

            } while (flag);
            return continente;

        }
        static int PedirDias()
        {
            int cantidadDias = 0;
            Console.WriteLine("Ingrese cantidad de dias");
            bool flag;

            do
            {
                flag = false;
                bool cd = int.TryParse(Console.ReadLine(), out cantidadDias);
                if (cd == false)
                {
                    Console.WriteLine("Ingrese un dato numerico");
                    flag = true;
                }

            } while (flag);
            
            return cantidadDias;
        }

        static string PedirMetodoPago()
        {
            string metPago;
            bool flag;
            do
            {
                Console.WriteLine("Seleccione un metodo de pago: \ndebito \ncredito \nefectivo \nmercado pago \ncheque \nleliq");
                metPago = Console.ReadLine();
                
                if (metPago == "debito" || metPago == "credito" || metPago == "efectivo" || metPago == "mercado pago" || metPago == "cheque" || metPago == "leliq")
                {
                    flag = false;
                }
                else { Console.WriteLine("Ingrese un metodo valido"); flag = true; }

            } while (flag);
            return metPago;

        }
       
        static float Descuento(string continente, string pago, float precio)
        {
            
            if (continente == "america" && pago == "debito")
            {
                precio -= (precio * 0.15f);
                precio -= (precio * 0.10f);
            }
            else if (continente == "america")
            {
                precio -= (precio * 0.15f);
            }

            if ((continente == "africa" || continente == "oceania") && (pago == "mercado pago" || pago == "efectivo"))
            {
                precio -= (precio * 0.30f);
                precio -= (precio * 0.15f);
            }
            else if (continente == "africa" || continente == "oceania")
            {
                precio -= (precio * 0.30f);
            }

            if (continente == "europa")
            {
                precio -= (precio * 0.20f);
                if (pago == "debito")
                {
                    precio -= (precio * 0.15f);
                }
                else if (pago == "mercado pago")
                {
                    precio -= precio * 0.10f;
                }
                else
                {
                    precio -= precio * 0.05f;
                }
            }

            if (continente == "asia")
            {
                precio += (precio * 0.20f);
            }

            if (pago == "cheque")
            {
                precio += precio * 0.15f;
            }
            
            return precio;
        }
    }
}
