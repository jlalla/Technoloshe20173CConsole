using System;

namespace Primero
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Julieta";
            int edad = 10;
            //bool existe = true;
            //char letra = 'A';
            //string otroNombre;
            //otroNombre = "Jorge";
            
            Console.WriteLine("Hola a todos!");
            Console.WriteLine("Cómo les va?!");
            Console.WriteLine("Cuál es tu nombre?");
            nombre = Console.ReadLine();
            Console.WriteLine("Tu nombre es: " + nombre);
            Console.WriteLine("Cuál es tu edad?");
            edad = int.Parse(Console.ReadLine()); //Convert.ToInt32(...)
            if(edad >= 18)
            {
                 Console.WriteLine("Sos mayor de edad.");
            }
            else
            {
                Console.WriteLine("Sos menor de edad");
            }

            //Vemos como funciona el switch
            Console.WriteLine("Cantidad de parámetros: " + args.Length);
            switch(args.Length)
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
            if(args.Length == 0)
            {
                Console.WriteLine("No tiene parámetros");
            }
            else if(args.Length == 1){
                Console.WriteLine("Tiene un parámetro");
            }
            else{
                Console.WriteLine($"Tiene {args.Length} parámetros");
            }
        }
    }
}
