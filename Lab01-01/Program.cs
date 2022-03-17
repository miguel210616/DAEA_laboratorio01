using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicación de dos números");
                Console.WriteLine("[5] División de dos números");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos");
                Console.WriteLine("[7] Convertir C° a F°");
                Console.WriteLine("[8] Convertir F° a C°");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer multiplicador");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo multiplicador");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", x, y, Multiplicacion(x, y));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el dividendo");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el divisor");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La cociente de {0} y {1} es {2}", m, n, Division(m, n));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Los 10 primeros números primos son: ");
                        NumPrimos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese la temperatura en C°");
                        int temp = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0} C° equivale a {1} F°",temp,CtoF(temp));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese la temperatura en F°");
                        int temp2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0} F° equivale a {1} C°", temp2, FtoC(temp2));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
        }

        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }
        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }
        static int Division(int a, int b)
        {
            return a / b;
        }

        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        static void NumPrimos()
        {
            int cont = 1;
            int n = 2;

            while(cont <= 10)
            {
                bool esPrimo = true;

                for(int i=2; i < n; i++)
                {
                    if(n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine(n);
                    cont++;
                }
                n++;
            }
            

        }

        static int CtoF(int tempC)
        {
            return (tempC * 9)/5+32;
        }

        static int FtoC(int tempF)
        {
            return ((tempF - 32) * 5) / 9;
        }
    }
}
