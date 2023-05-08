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
            // Definir variables.
            List<string> actividades = new List<string>
                {
                    "1. Palindromo",
                    "2. Serie Fibonacci",
                    "3. Calculadora de notación polaca inversa",
                    "4. Calcular ecuación cuadratica",
                    "5. Calcular IMC"
                };
            bool flag = true; // Si "flag" se vuelve false dentro de while, no se volverá a repetir el programa.

            // Empieza programa.
            Console.WriteLine("Bienvenido al test de conocimientos y habilidades .NET de Indexar.");

            while (flag)
            {
                Console.WriteLine("\nLista de actividades");
                foreach (var actividad in actividades)
                {
                    Console.WriteLine(actividad);
                }
                Console.WriteLine("Seleccione alguna actividad ingresando el número (Para salir ingrese 0):\n");
                try // try catch por si se introduce un dato que no es integer al input siguiente.
                {
                    int numActividad = Convert.ToInt32(Console.ReadLine()); // Input para seleccionar el número de actividad.
                    switch (numActividad)
                    {
                        // 1. Palindromos
                        case 1:
                            Console.WriteLine("\nACTIVIDAD 1: PALINDROMOS\n");
                            Console.WriteLine("Escriba una palabra para determinar si esta es un palindromo:\n");
                            try
                            {
                                string palindromo = Console.ReadLine();
                                if (Palindromo.IsPalindromo(palindromo)) // Llamada a la clase Palindromo dentro de la carpeta Functions.
                                {
                                    Console.WriteLine("\nLa palabra escrita SÍ es un palindromo.");
                                    Console.WriteLine("\nPalabra normal:");
                                    Console.WriteLine(palindromo);
                                    Console.WriteLine("\nPalabra en reversa:");
                                    Console.WriteLine(Palindromo.ReverseString(palindromo));
                                }
                                else
                                {
                                    Console.WriteLine("\nLa palabra escrita NO es un palindromo.");
                                    Console.WriteLine("\nPalabra normal:");
                                    Console.WriteLine(palindromo);
                                    Console.WriteLine("\nPalabra en reversa:");
                                    Console.WriteLine(Palindromo.ReverseString(palindromo));
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\n¡ERROR! Debe ser una palabra válida.");
                            }
                            break;

                        // 2. Serie Fibonacci
                        case 2:
                            Console.WriteLine("\nACTIVIDAD 2: SERIE FIBONACCI\n");
                            Console.WriteLine("Escriba un número para definir la longitud de la serie:\n");
                            try // try catch por si se introduce un dato que no es integer al input siguiente.
                            {
                                int longitudSerie = Convert.ToInt32(Console.ReadLine()); // Input para seleccionar la longitud de la serie.
                                List<int> listaSerieFibonacci = Fibonacci.ListSerie(longitudSerie); // Llamada a la clase Fibonacci dentro de la carpeta Functions.
                                Console.WriteLine("\nEsta es la serie fibonacci con longitud " + longitudSerie + ":\n");
                                foreach (int numeroSerie in listaSerieFibonacci)
                                {
                                    if (numeroSerie == listaSerieFibonacci.Last())
                                    {
                                        Console.Write(numeroSerie + "\n");
                                    }
                                    else
                                    {
                                        Console.Write(numeroSerie + ",");
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\n¡ERROR! Debe ser un número válido.");
                            }
                            break;

                        // 3. Calculadora de notación polaca inversa
                        case 3:
                            break;

                        // 4. Calcular ecuación cuadrática
                        case 4:
                            Console.WriteLine("\nACTIVIDAD 4: CALCULAR ECUACIÓN CUADRÁTICA\n");
                            Console.WriteLine("\nEscriba un numero para la posición a:\n");
                            try // try catch por si se introduce un dato que no es double.
                            {
                                double a = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("\nEscriba un numero para la posición b:\n");
                                double b = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("\nEscriba un numero para la posición c:\n");
                                double c = Convert.ToDouble(Console.ReadLine());
                                EcuacionCuadratica.CalculateQuadraticEquation(a, b, c);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\n¡ERROR! Debe ser un número válido.");
                            }
                            break;

                        // 5. Calcular IMC
                        case 5:
                            Console.WriteLine("\nACTIVIDAD 5: CALCULAR IMC\n");
                            Console.WriteLine("\nEscriba el peso en Kilos (ejemplo: 103,5) para calcular IMC:\n");
                            try // try catch por si se introduce un dato que no es double.
                            {
                                double peso = Convert.ToDouble(Console.ReadLine()); // Input para seleccionar el peso para calcular IMC.
                                Console.WriteLine("\nEscriba la estatura en metros (ejemplo: 1,65) para calcular IMC:\n");
                                double estatura = Convert.ToDouble(Console.ReadLine()); // Input para seleccionar la estatura para calcular IMC.
                                double imc = IMC.CalculateBMI(peso, estatura);
                                string categoria = IMC.BMICategory(imc);
                                Console.WriteLine("\nEl IMC calculado con peso " + peso + "[Kg] y estatura " + estatura + "[m] es de " + Convert.ToInt64(imc) + ", dando asi que la categoria es " + categoria + ".");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\n¡ERROR! Debe ser un número válido.");
                            }
                            break;

                        // Si el numero seleccionado no está dentro de la lista entra acá.
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
                    Console.WriteLine("\nGracias por usar el programa\n");
                    break;
                }
            }
        }
    }
}