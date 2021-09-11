using System;

namespace PandSofTri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для вычисления периметра и площади прямоугольника, поочерёдно введите координаты его вершин:");
            Console.WriteLine("Сначала для первой точки:");
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("...Потом для второй:");
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
            float per = 2*(Math.Abs(x1 - x2)+Math.Abs(y1 - y2));
            float sq = Math.Abs(x1 - x2)*Math.Abs(y1 - y2);
            Console.WriteLine($"Периметр для прямоугольника, с введёнными координатами вершин: {per}; площадь: {sq}.");
        }
    }
}
