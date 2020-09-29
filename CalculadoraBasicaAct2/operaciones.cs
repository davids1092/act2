using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraBasicaAct2
{
    public static class operaciones // clase encargada de realizar las operaciones matematicas.
    {
        
       public static double suma(double num1, double num2)
        {
            Console.WriteLine($"el resultado de la Suma es: {num1 + num2}");
            return num1 + num2;
        }
        public static double resta(double num1, double num2)
        {
            Console.WriteLine($"el resultado de la Resta es: {num1 - num2}");
            return num1 - num2;
        }
        public static double Multiplicacion(double num1, double num2)
        {
            Console.WriteLine($"el resultado de la Resta es: {num1 * num2}");
            return num1 * num2;
        }
        public static double Division(double num1, double num2)
        {
            Console.WriteLine($"el resultado de la Division es: {num1 / num2}");
            return num1 / num2;
        }
    }
}
