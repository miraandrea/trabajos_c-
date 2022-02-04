using System;
using System.IO;
using System.Diagnostics;

namespace PruebaVector
{
    class PruebaVector
    {
        public int[] vector;
        DateTime start = DateTime.Now;
        string newone = "";
        public void Cargar()
        {
            Console.Write("Fecha iniciada " + start);
            Console.WriteLine("");
            Console.WriteLine("Metodo de insercion directa");
            Console.Write("Cuantos longitud del vector:");
            int linea;
            linea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            vector = new int[linea];
            for (int f = 0; f < vector.Length; f++)
            {
                Random aleatorio = new Random();
                linea = aleatorio.Next(-1000, 999);
                Console.WriteLine(linea);

                vector[f] = (linea);
            }
        }
        public void InsercionDirecta()
        {
            int auxili;
            int j;
            for (int i = 0; i < vector.Length; i++)
            {
                auxili = vector[i];
                j = i - 1;
                while (j >= 0 && vector[j] > auxili)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }
                vector[j + 1] = auxili;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("");
            Console.WriteLine("Vector ordenados en forma ascendente");
            Console.WriteLine("");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
            Console.WriteLine("");


            Console.WriteLine(newone);
            DateTime end = DateTime.Now;
            TimeSpan duration = end - start;
            Console.WriteLine("Tiempo de demora " + duration.ToString());
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            PruebaVector pv = new PruebaVector();
            pv.Cargar();
            pv.InsercionDirecta();
            pv.Imprimir();
        }

    }
}