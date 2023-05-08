// Programa realizado por Matías Leal.
// Este programa utiliza while(flag) para funcionar y volver a funcionar,
// cuando esta variable se encuentre en false el programa no volverá a abrir.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIndexar.NET.Functions;

namespace TestIndexar.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir variables
            List<string> actividades = new List<string>
                {
                    "1. Palindromo",
                    "2. Fibonnacci",
                    "3. Calculadora de notación polaca inversa",
                    "4. Calcular ecuación cuadratica",
                    "5. Calcular IMC"
                };
            bool flag = true; // Si "flag" es false, no se volverá a repetir el programa 

            // Empieza programa
            Console.WriteLine("Bienvenido al test de conocimientos y habilidades .NET de Indexar.");

            while (flag)
            {
                Console.WriteLine("\nLista de actividades");
                foreach (var actividad in actividades)
                {
                    Console.WriteLine(actividad);
                }
                Console.WriteLine("Seleccione alguna actividad ingresando el número (Para salir ingrese 0):");
                try
                {
                    int numActividad = Convert.ToInt32(Console.ReadLine());
                    switch (numActividad)
                    {

                        case 1:
                            Console.WriteLine("\nACTIVIDAD 1: PALINDROMOS\n");
                            Console.WriteLine("Escriba una palabra para determinar si esta es un palindromo.");
                            try
                            {
                                string palindromo = Console.ReadLine();
                                if (Palindromo.IsPalindromo(palindromo))
                                {
                                    Console.WriteLine("\nLa palabra escrita SÍ es un palindromo.");
                                    Console.WriteLine("\nPalabra normal:");
                                    Console.WriteLine(palindromo);
                                    Console.WriteLine("\nPalabra en reversa:");
                                    Console.WriteLine(Palindromo.ReverseString(palindromo));
                                }
                                else
                                {
                                    Console.WriteLine("La palabra escrita NO es un palindromo.");
                                    Console.WriteLine("Palabra normal:");
                                    Console.WriteLine(palindromo);
                                    Console.WriteLine("Palabra en reversa:");
                                    Console.WriteLine(Palindromo.ReverseString(palindromo));
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\n¡ERROR! Debe ser una palabra válida.");
                            }
                            break;
                        default:
                            Console.WriteLine("\nPor favor seleccione un número dentro de la lista");
                            break;
                        case 0:
                            flag = false;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n¡ERROR! Debe ser un número válido.");
                }
                if (!flag)
                {
                    Console.WriteLine("Gracias por usar el programa");
                    break;
                }
            }
        }
    }
}