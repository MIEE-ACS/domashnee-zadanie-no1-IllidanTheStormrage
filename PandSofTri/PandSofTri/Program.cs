using System;

namespace PandSofTri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для вычисления периметра и площади прямоугольника, поочерёдно введите координаты его вершин.\nСначала для первой точки:\nX:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Y:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("...Потом для второй:\nX:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Y:");
            double y2 = double.Parse(Console.ReadLine());
            double per = 2*(Math.Abs(x1 - x2)+Math.Abs(y1 - y2));
            per = Math.Round(per, 3);
            double sq = Math.Abs(x1 - x2)*Math.Abs(y1 - y2);
            sq = Math.Round(sq, 3);
            Console.WriteLine($"Периметр для прямоугольника, с введёнными координатами вершин: {per}; площадь: {sq}.");
        }
    }
}
