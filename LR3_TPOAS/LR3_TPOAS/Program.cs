using System;

namespace LR_6._1_С_sharp__STP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Конструктор:");
            Point P = new Point(0, 0, 0); // Точка
            P_A Pa = new P_A(0, 0, 0, 0); // Отрезок
            Pa.Display();
            Console.WriteLine("Инициализация:");
            P.Init(1, 2, 3);
            Pa.Init(1, 2, 3, 4);
            float A = Pa.GetA();
            Pa.Display();
            A = 5;
            Console.WriteLine("Замена:");
            Pa.PutA(A);
            Pa.Display();
            A = Pa.OP();
            float oP = P.OP();
            Console.WriteLine("Расстояние от точки до начала координат: " + oP);
            Console.WriteLine("Расстояние от отрезка до начала координат: " + A);

            Console.Read(); // Ожидание ввода перед завершением работы
        }
    }
}