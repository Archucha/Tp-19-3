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
                    while (i<5)
                    {
                        Console.WriteLine("Las canciones ingresadas son");
                        Console.WriteLine(canciones[i]);
                        i++;
                    }
                    break;

                default:

                    break;
            }
        }
    }
}
