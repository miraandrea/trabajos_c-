using System;

namespace algoritmosciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Imprimir cinco veces la palabra “Sena”");
            Console.WriteLine("2: Leer el valor de N e imprimir los primeros N números naturales.");
            Console.WriteLine("3: Leer el valor de N, imprimir y sumar los números de 1 a N");
            Console.WriteLine("4: Calcular la suma de los primeros N números pares");
            Console.WriteLine("5: Imprimir la serie de los N primeros números impares y la suma de ellos");
            Console.WriteLine("6: calcular el factorial de un número");
            Console.WriteLine("7: Generar e imprimir la serie y la suma los primero N números múltiplos de M");
            Console.WriteLine("8: Generar e imprimir las primeras N tablas de multiplicar");
            Console.WriteLine("9: Genere e imprima los números y la sumatoria de la serie fibbonaci");

            Console.WriteLine("que opcion quieres escoger: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if(opcion == 1)
            {
                for(int e = 0; e<6; e++)
                {
                    Console.WriteLine("Sena");
                }
            }

            if (opcion == 2)
            {
                Console.WriteLine("valor de N: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= numero; i++)
                {
                    Console.WriteLine(i);
                }
            }

            if (opcion == 3)
            {
                Console.WriteLine("valor de N: ");
                int nume = Convert.ToInt32(Console.ReadLine());
                int suma = 0;
                for (int a = 0; a <= nume; a++)
                {
                    suma = suma + a;
                    Console.WriteLine(a);
                }
                Console.WriteLine("la suma es: {0}", suma);
            }

            if (opcion == 4)
            {
                Console.WriteLine("valor de N: ");
                int nume = Convert.ToInt32(Console.ReadLine());
                int su = 0;
                for (int d = 0; d <= nume; d++)
                {
                    int par = d % 2;
                    if (par == 0)
                    {
                        su = su + d;
                        Console.WriteLine(d);
                        Console.WriteLine("la suma es: {0}", su);
                    }
                }
            }

            if (opcion == 5)
            {
                Console.WriteLine("valor de N: ");
                int nume = Convert.ToInt32(Console.ReadLine());
                int s = 0;
                for (int b = 0; b <= nume; b++)
                {
                    int impar = b % 2;
                    if (impar != 0)
                    {
                        s = s + b;
                        Console.WriteLine(b);
                        Console.WriteLine("la suma es: {0}", s);
                    }
                }
            }

            if (opcion == 6)
            {
                Console.WriteLine("valor de N: ");
                int nume = Convert.ToInt32(Console.ReadLine());

                for (int t = 0; t <= nume; t++)
                {
                    int mul = t * t;
                    Console.WriteLine("la factorial es: {0}", mul);
                }
            }

            if (opcion == 7)
            {
                Console.WriteLine("Ingrese un numero: ");
                int nume = Convert.ToInt32(Console.ReadLine());
                int n = 10;
                int s = 0;
                int contador = 1;

                while (contador <= n)
                {
                    s = s + contador;
                    int m = contador * nume;
                    Console.WriteLine("Suma: {0}", s);
                    Console.WriteLine("Multiplo: {0}", m);
                    contador = contador + 1;
                }
            }

            if (opcion == 8)
            {
                int multiplicar = 9;
                int n = 1;

                while (n <= multiplicar)
                {
                    Console.WriteLine(multiplicar + "*" + n + "=" + multiplicar * n);
                    n = n + 1;
                }
            }

            if (opcion == 9)
            {
                Console.WriteLine("Ingrese un numero fibbonaci: ");
                int cantidad = int.Parse(Console.ReadLine());
                long a = 0;
                long b = 1;
                long aux = 0;


                for (int i = 0; i < cantidad; i++)
                {
                    if (i == 0)
                    {
                        Console.Write("{0}", a);
                    }
                    else
                    {
                        aux = a;
                        a = b;
                        b = aux + a;
                        Console.Write(", {0}", a);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
