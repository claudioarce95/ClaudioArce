using System;

namespace Punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string color;
            string seguir;
            int cantRojos = 0;
            int cantRojosMayor = 0;
            int cantMenor5k = 0;
            int vehiculos = 0;
            int valorTotal = 0;
            int max = int.MinValue;
            string colorCaro = "";


            do
            {
                color = PedirColor();
                valor = PedirValor();

                if (color == "rojo")
                {
                    cantRojos++;
                }
                if (color == "rojo" && valor > 5000)
                {
                    cantRojosMayor++;
                }
                if (valor < 5000)
                {
                    cantMenor5k++;
                }

                if (valor > max)
                {
                    max = valor;
                    colorCaro = color;
                }

                valorTotal += valor;
                vehiculos++;

                Console.WriteLine("Desea seguir? Ingrese si o no");
                seguir = Console.ReadLine();

            } while (seguir == "si");

            int promedioV = valorTotal/vehiculos;
            Console.WriteLine("Cantidad de rojos: {0}", cantRojos);
            Console.WriteLine("Cantidad de rojos con precio mayor a 5000: {0}", cantRojosMayor);
            Console.WriteLine("Cantidad de vehiculos con precio menor a 5000: {0}", cantMenor5k);
            Console.WriteLine("El promedio de todos los vehiculos es: {0}", promedioV);
            Console.WriteLine("El vehiculo mas caro es de {0} y es de color {1}", max, colorCaro);
        }

       
        static string PedirColor()
        {
            string color;
            bool flag;
            Console.WriteLine("Ingrese el color del vehiculo");
            do
            {
                color = Console.ReadLine();
                if (color == "rojo" || color == "amarillo" || color == "verde")
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Ingrese un color valido(rojo, amarillo o verde)");
                    flag = true;
                }

            } while (flag); 

            return color;
        }

        static int PedirValor()
        {
            int valor;
            bool flag;
            Console.WriteLine("Ingrese el valor del auto");
            do
            {
                bool n = int.TryParse(Console.ReadLine(), out valor);
                if (valor > 0 && valor <= 10000)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Ingrese un valor entre 0 y 10000");
                    flag = true;
                }
                
            } while (flag);

            return valor;

        }

    }
}
