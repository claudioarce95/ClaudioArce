using System;

namespace Punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("Ingrese un numero");
            bool flag;
            do
            {
                flag = false;
                bool cd = int.TryParse(Console.ReadLine(), out num1);
                if (cd == false)
                {
                    Console.WriteLine("El dato ingresado no es un numero");
                    flag = true;
                }

            } while (flag);
            
            Console.WriteLine("Ingrese otro numero");
            do
            {
                flag = false;
                bool cd = int.TryParse(Console.ReadLine(), out num2);
                if (cd == false)
                {
                    Console.WriteLine("El dato ingresado no es un numero");
                    flag = true;
                }

            } while (flag);

            int resto = num1 % num2;

            if (num1 == num2)
            {
                int resultado = num1 * num1;
                Console.WriteLine("El cuadrado del numero es: {0}", resultado);
            }
            if (resto == 0)
            {
                int resultado = num1 - num2;
                Console.WriteLine("La resta es: {0}", resultado);
            }
            else 
            {
                Console.WriteLine("El resto es {0}", resto);
            }
            if (resto > 3)
            {
                Console.WriteLine("El resto es mayor a 3");
            }

        }
    }
}
