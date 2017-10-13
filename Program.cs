using System;
using System.Collections;
using System.Collections.Generic;

namespace Primero
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Julieta";
            int edad = 10;

            Console.WriteLine("Hola a todos!");
            Console.WriteLine("Cómo les va?!");

            Console.WriteLine("Cuál es el nombre?");
            nombre = Console.ReadLine();

            //corte de control
            while (!nombre.Equals("salir"))
            {
                //mientras se cumple la condición entra
                Console.WriteLine("Tu nombre es: " + nombre);
                Console.WriteLine("Cuál es su edad?");
                edad = int.Parse(Console.ReadLine()); //Convert.ToInt32(...)
                if (edad >= 18)
                {
                    Console.WriteLine("Es mayor de edad.");
                }
                else
                {
                    Console.WriteLine("Es menor de edad");
                }

                Console.WriteLine("Cuál es el nombre?");
                nombre = Console.ReadLine();
            }

            //mostramos 6 veces hola
            for (int i = 0; i < 6; i++) //i++ -->> i = i+1
            {
                Console.WriteLine("Hola");
            }

            //mostramos hola 10 veces pero con while
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine("Hola While");
                j++;
            }

            //Vemos como funciona el switch
            Console.WriteLine("Cantidad de parámetros: " + args.Length);
            switch (args.Length)
            {
                case 0:
                    Console.WriteLine("No tiene parámetros");
                    break;
                case 1:
                    Console.WriteLine("Tiene un parámetro");
                    break;
                default:
                    Console.WriteLine("Tiene " + args.Length + " parámetros");
                    break;
            }


            /* 
            El switch se puede poner como
            varios if
             */
            if (args.Length == 0)
            {
                Console.WriteLine("No tiene parámetros");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("Tiene un parámetro");
            }
            else
            {
                Console.WriteLine($"Tiene {args.Length} parámetros");
            }

            //ARRAYS
            string color = "rojo";
            //tamaño fijo, mismo tipo
            string[] colores = new string[] { "azul", color, "blanco", "negro" };
            string[] coloresOtro = new string[4];
            Console.WriteLine("el tercer color es el: " + colores[2]);
            colores[0] = "verde";

            //iteramos los items con for
            for (int k = 0; k < colores.Length; k++)
            {
                Console.WriteLine("Color: " + colores[k]);
            }

            //también los podemos iterar con foreach
            foreach (string item in colores) //recorre todo el array
            {
                Console.WriteLine("Color: " + item);
            }

            //arrays multidimensionales
            int[,] multi = { { 1, 3, 4 }, { 2, 4, 2 }, { 1, 3, 4 } };
            for (int l = 0; l < 3; l++)
            {
                for (int m = 0; m < 3; m++)
                {
                    Console.WriteLine(multi[l, m]);
                }
            }

            //LISTAS
            //es dinámico, no tenemos que definir la cantidad
            List<string> listaColores = new List<string>();
            listaColores.Add("azul");
            listaColores.Add("blanco");
            listaColores.Insert(1, "rojo");

            foreach(string item in listaColores)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
