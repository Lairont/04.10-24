using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Треугольник задан координатами своих вершин. Найти периметр и площадь треугольника.
            Console.Write("X1=");
            int x1 = int.Parse(Console.ReadLine());

            Console.Write("X2=");
            int x2 = int.Parse(Console.ReadLine());

            Console.Write("X3=");
            int x3 = int.Parse(Console.ReadLine());

            Console.Write("Y1=");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Y2=");
            int y2 = int.Parse(Console.ReadLine());

            Console.Write("Y3=");
            int y3 = int.Parse(Console.ReadLine());

            double side1 = Math.Sqrt(Math.Pow((x2 - x1),2 ) + Math.Pow((y2 - y1),2 ));

            double side2 = Math.Sqrt(Math.Pow((x3 - x2),2 ) + Math.Pow((y3 - y2),2 ));
            
            double side3 = Math.Sqrt(Math.Pow((x1 - x2),2 ) + Math.Pow((y1 - y2),2 ));

            double P = side1 + side2 + side3;
            double Pp = (side1 + side2 + side3)/2;
            double S = Math.Sqrt(Pp*(Pp - side1) * (Pp - side2) * (Pp - side3));

            Console.WriteLine($"P= {P}\nS= {S}");
            Console.ReadLine();
        }
    }
}
