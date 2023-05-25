using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            char operador;

            //enviamos un mensaje de bienvenida y una descripcion del programa

            Console.WriteLine("bienvenido a nuestro programa");
            Console.WriteLine("Este programa permite operaciones basica sobre dos numero");
            Console.WriteLine("-----------------");

            Console.WriteLine("De el valor del primer numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("De el valor del segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indique la operacion(*,+,-,/)");
            operador = char.Parse(Console.ReadLine());
            /*identificamos el tipo de operacion a realizar haciendo uso del condicional IF*/

            if (operador == '*')
            {
                Console.WriteLine("realiza la multiplicacion de" +  ( num1*num2 ));
            }
            if (operador == '/')
            {
                Console.WriteLine("realiza la division de" +  ( num1/num2 ));
            }
            if (operador == '+')
            {
                Console.WriteLine("realiza la suma de" +  ( num1+num2));
            }
            if (operador == '-')
            {
                Console.WriteLine("realiza la resta de" +  ( num1+num2));
            }

            switch (operador)
            {
                case '*'
                con
                default:
                    break;
            }

            Console.ReadLine();
        }

    }
}
