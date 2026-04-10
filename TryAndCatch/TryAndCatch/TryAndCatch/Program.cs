using System;

namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingresa un número");
            string valorIngresado = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int resultado;

            try
            {
                resultado = num1 / num2;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("No se puede dividir por cero");
            }

     


            try
            {
                int valorComoInt = int.Parse(valorIngresado);
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato del valor ingresado es incorrecto");
                
            }
            catch (OverflowException)
            {
                Console.WriteLine("El numero ingresado es demasiado largo o demasiado corto");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("No se ha ingresado ningún valor");
            }
            finally
            {
                Console.WriteLine("Esta frase aparecerá pase lo que pase");
            }

           
            Console.Read();
        }
    }
}
