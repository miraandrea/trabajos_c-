using System;

namespace algoritmo_lista_taller_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea una Lista con un tamaño de 10, inserta los valores numéricos
            //que desees de la manera que  quieras y muestra por pantalla la media
            //de valores del array

            int[] arrayNumeros = { 1, 7, 3, 4, 5, 6, 2, 8, 9, 10 };

            for (int i = 0; i < arrayNumeros.Length; i++)
            Console.WriteLine(i);

            //2.	Crea una Lista donde tu le indiques el tamaño por teclado y crear
            //una función que rellene el array o arreglo con los múltiplos de un
            //numero pedido por teclado. Por ejemplo, si defino un array de tamaño 5
            //y eligo un 3 en la función, el array contendrá 3, 6, 9, 12, 15.
            //Muestralos por pantalla usando otra función distinta.

            string[] array = {};
            Console.WriteLine("Valor de tamaño");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[tamaño];
            Console.WriteLine("Numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < tamaño; i++)
            {
                int mul = i * numero;
                array[0] = "mul";
            }
            Console.WriteLine(array);

        }
    }
}
