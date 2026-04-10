using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = { 10, 20, 45, 60 };
            int suma = 0;

            for (int i = 0; i < numeros.Length; i++)
            { 
            suma += numeros[i]; 
            }

            int promedio = suma / numeros.Length;

            Console.WriteLine("La suma del arreglo es : {0}", suma);
            Console.WriteLine("El Promedio del arreglo es : {0}", promedio);

        }

    }
}
