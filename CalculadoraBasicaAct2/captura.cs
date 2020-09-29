using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraBasicaAct2
{
    public class simbolo //clase encargada de realizar la captura de datos para realizar las operaciones.
    {
        public static char simbolo1;
        public static double num1;
        public static double num2;
        public static void signo()
        {
            
                Console.WriteLine("digite simbolo para realizar operación");
                Console.WriteLine("digite + para sumar" + "\n" +
                    "digite - para restar" + "\n" +
                    "digite * para Multiplicar" + "\n" +
                    "digite / para Dividir" + "\n");
                simbolo1 = char.Parse(Console.ReadLine());


            Console.WriteLine("digita primer numero para operacion");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite el segundo numero para la operacion");
            num2 = double.Parse(Console.ReadLine());


        }
    }
}
