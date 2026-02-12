using System;
using System.Collections.Generic;

namespace Programacion_estructurada_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadpersonas;
            bool cantidadValida = false;
            do
            {
                Console.WriteLine("Ingresa la cantidad de personas a clasificar (1 o mas personas):");
                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out cantidadpersonas) || cantidadpersonas < 1)
                {
                    Console.WriteLine("Por favor ingresa un número entero válido que sea igual a 1 o mayor que este.");
                }
                else
                {
                    cantidadValida = true;
                }

            } 
            while (!cantidadValida);

            if (cantidadpersonas == 1)
            {
                Console.WriteLine("Ingresa el nombre de la persona:");
                string nombrepersona = Console.ReadLine();

                int edadpersona = LeerEdadValida(1);

                if (edadpersona >= 18)
                {
                    Console.WriteLine(nombrepersona + " es mayor de edad.");
                }
                else
                {
                    Console.WriteLine(nombrepersona + " es menor de edad.");
                }
            }
            else 
            {
                List<string> nombresGenerales = new List<string>();
                List<int> edadesGenerales = new List<int>();

                List<string> nombresPersonasMayores = new List<string>();
                List<int> edadesPersonasMayores = new List<int>();

                List<string> nombresPersonasMenores = new List<string>();
                List<int> edadesPersonasMenores = new List<int>();

                for (int i = 1; i <= cantidadpersonas; i++)
                {
                    Console.WriteLine($"Ingresa el nombre de la persona {i}:");
                    string nombrepersona = Console.ReadLine();

                    int edadpersona = LeerEdadValida(i);

                    nombresGenerales.Add(nombrepersona);
                    edadesGenerales.Add(edadpersona);

                    if (edadpersona >= 18)
                    {
                        nombresPersonasMayores.Add(nombrepersona);
                        edadesPersonasMayores.Add(edadpersona);
                    }
                    else
                    {
                        nombresPersonasMenores.Add(nombrepersona);
                        edadesPersonasMenores.Add(edadpersona);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("--Lista general de personas--");
                for (int i = 0; i < nombresGenerales.Count; i++)
                {
                    Console.WriteLine(nombresGenerales[i] + " - " + edadesGenerales[i]);
                }
                Console.WriteLine();

                if (nombresPersonasMayores.Count > 0)
                {
                    Console.WriteLine("--Personas Mayores de Edad--");
                    for (int i = 0; i < nombresPersonasMayores.Count; i++)
                    {
                        Console.WriteLine(nombresPersonasMayores[i] + " - " + edadesPersonasMayores[i]);
                    }
                    Console.WriteLine();
                }

                if (nombresPersonasMenores.Count > 0)
                {
                    Console.WriteLine("--Personas Menores de Edad--");
                    for (int i = 0; i < nombresPersonasMenores.Count; i++)
                    {
                        Console.WriteLine(nombresPersonasMenores[i] + " - " + edadesPersonasMenores[i]);
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Fin del programa. Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }

        static int LeerEdadValida(int numeroPersona)
        {
            int edad;
            bool edadValida = false;

            do
            {
                Console.WriteLine($"Ingresa la edad de la persona {numeroPersona}:");
                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out edad))
                {
                    Console.WriteLine("Por favor ingresa un número entero válido para la edad.");
                }
                else
                {
                    edadValida = true;
                }

            } while (!edadValida);

            return edad;
        }
    }
}
