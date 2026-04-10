using System;

class Program
{
    static void Main()
    {
        // 1. Pedir la cantidad
        Console.Write("¿Cuántas calificaciones vas a ingresar?: ");
        int cantidad = int.Parse(Console.ReadLine());

        // 2. Crear variables para guardar los resultados
        double suma = 0;
        double masAlta = 0;
        double masBaja = 100; // Empezamos con un número alto para poder bajar

        // 3. El bucle: Pedir datos y calcular al mismo tiempo
        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Ingresa la calificación " + i + ": ");
            double calificacionActual = double.Parse(Console.ReadLine());

            // Sumar para el promedio
            suma = suma + calificacionActual;

            // ¿Es esta la más alta que hemos visto?
            if (calificacionActual > masAlta)
            {
                masAlta = calificacionActual;
            }

            // ¿Es esta la más baja que hemos visto?
            if (calificacionActual < masBaja)
            {
                masBaja = calificacionActual;
            }
        }

        // 4. Calcular el promedio final
        double promedio = suma / cantidad;

        // 5. Mostrar todo
        Console.WriteLine("\n--- RESULTADOS ---");
        Console.WriteLine("La calificación más alta es: " + masAlta);
        Console.WriteLine("La calificación más baja es: " + masBaja);
        Console.WriteLine("El promedio de todos es: " + promedio);
    }
}
