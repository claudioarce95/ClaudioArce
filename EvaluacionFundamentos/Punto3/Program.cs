using System;

namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilos = 0;
            string saborIngresado;
            int cantCarne = 0;
            int cantVerduras = 0;
            int cantPollo = 0;
            int kilosCarne = 0;
            string bolsamin = "";
            int min = int.MaxValue;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese una bolsa de alimento");
                int kilosIngresados = IngresarKilos();
                kilos = kilos + kilosIngresados;
                saborIngresado = IngresarSabor();
               
                
                switch (saborIngresado)
                {
                    case "carne":
                        cantCarne++;
                        kilosCarne += kilosIngresados;
                        break;
                    case "pollo":
                        cantPollo++;
                        break;
                    case "vegetales":
                        cantVerduras++;
                        break;

                    default:
                        break;
                }
                if (kilosIngresados < min)
                {
                    min = kilosIngresados;
                    
                    bolsamin = saborIngresado;
                }
            }

            float promedioKgCarne = kilosCarne / cantCarne;
            
            Console.WriteLine("Promedio de Kg totales: {0}", kilos/10);
            Console.WriteLine("Bolsa mas liviana: {0} , {1} kg", bolsamin, min);
            Console.WriteLine("Cantidad de bolsas sabor carne: {0}, promedio kg carne: {1}", cantCarne , promedioKgCarne );
        }
       
        static int IngresarKilos()
        {
          
            bool flag;
            int peso;
                
                do
                {
                    Console.WriteLine("Ingrese peso en kilos(entre 0 y 500): ");
                    bool n = int.TryParse(Console.ReadLine(),out peso);
                    if (peso > 0 && peso <= 500)
                    {
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un peso valido");
                        flag = true;
                    }
                } while (flag);

            return peso;
            
        }

        static string IngresarSabor()
        {
            string sabor;
            bool flag;
            do
            {
                Console.WriteLine("Ingrese sabor: ");
                sabor = Console.ReadLine();
                if (sabor == "carne" || sabor == "vegetales" || sabor == "pollo")
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Ingrese un sabor valido(carne, pollo, vegetales)");
                    flag = true;
                }
            } while (flag);

            return sabor;
        }
    }
}
