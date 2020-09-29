using System;

namespace CalculadoraBasicaAct2
{
    class Program // clase encargada de procesar los datos que se capturan en otras clases.
    {
        private static string mensaje = "Hola Bienvenido a Mi Calculadora \n";
        public static void Main(string[] args)
        {
            Console.WriteLine(mensaje);
             char signo;
            simbolo.signo();
            signo = simbolo.simbolo1;
            double num1 = simbolo.num1;
            double num2 = simbolo.num2;
            switch (signo)
            {
                case ('+'):
                    operaciones.suma(num1,num2);
                    break;
                case ('-'):
                    operaciones.resta(num1, num2);
                    break;
                case ('*'):
                    operaciones.Multiplicacion(num1, num2);
                    break;
                case ('/'):
                    operaciones.Division(num1, num2);
                    break;
            }
        }
    }
}
