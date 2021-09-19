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
            //Нет смысла проверять входные данные, для них нет недопустимых значений
            double per = 2*(Math.Abs(x1 - x2)+Math.Abs(y1 - y2));//считаем периметр
            per = Math.Round(per, 3);//округляем
            double sq = Math.Abs(x1 - x2)*Math.Abs(y1 - y2);//считаем площадь
            sq = Math.Round(sq, 3);//округляем
            Console.WriteLine($"Периметр для прямоугольника, с введёнными координатами вершин: {per}; площадь: {sq}.");
        }
    }
}
