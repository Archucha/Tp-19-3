using System;

namespace Tp_19_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sel;
            Console.WriteLine("Ingrese a que trabajo desea ingresar 1-5");
            sel = int.Parse(Console.ReadLine());
            switch(sel)
            {
                case 1:
                    string[] canciones = new string[5];
                    while (i<5)
                    {
                        Console.WriteLine("Ingrese el nombre de una cancion");
                        canciones[i] = Console.ReadLine();
                        i++;
                    }
                    i = 0;
                    Console.WriteLine("Las canciones ingresadas son");
                    while (i<5)
                    {
                        Console.WriteLine(canciones[i]);
                        i++;
                    }
                    break;
                case 2:
                    string[] canciones2 = new string[5];
                    for (i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Ingrese el nombre de una cancion");
                        canciones2[i] = Console.ReadLine();
                    }
                    Console.WriteLine("Las canciones ingresadas son");
                    for (i = 0; i < 5; i++)
                    {
                        Console.WriteLine(canciones2[i]);
                    }
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion valida");
                    break;
            }
        }
    }
}
