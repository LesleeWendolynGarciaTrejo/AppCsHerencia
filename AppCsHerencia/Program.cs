using System;

namespace AppCsHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto2D a;
            a = new Punto2D(10, 17);
            Console.WriteLine(a.ToString());

            Punto2D b;
            b = new Punto2D(29, 21);

            Console.WriteLine(b.ToString());

            double d = a.Distancia(b);
            Console.WriteLine("Distancia " + d);

            Punto3D c;
            c = new Punto3D(10, 17);
            Console.WriteLine(c.ToString());

            Punto3D e;
            e = new Punto3D(10, 17);

            Console.WriteLine(e.ToString());
  

            Console.ReadKey();
        }

    }
}
       


  