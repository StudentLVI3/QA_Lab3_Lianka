using System;

namespace LR_6._1_С_sharp__STP
{
    // Базовый класс
    class Point
    {
        // (b) Исходные поля базового класса становятся protected
        // Поля класса (наследуемые)
        protected float X, Y, Z;

        // Методы класса (открытые)
        public Point()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        /*
	    (e) В базовом и производном классах создать конструкторы
	    с параметрами. Продемонстрировать в конструкторе производного 
	    класса с параметрами вызов конструктора базового класса
	    */
        public Point(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void Init(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void Display()
        {
            Console.WriteLine("Точка с координатами: (" + X + "; " + Y + "; " + Z + ")");
        }

        public float OP() // Расстояние от точки до начала координат
        {
            // OP = sqrt((X-X0)*(X-X0) + (Y-Y0)*(Y-Y0) + (Z-Z0)*(Z-Z0)) =>
            return (float)Math.Round(Math.Sqrt((X * X + Y * Y + Z * Z)), 3);
        }
    }

    // Производный класс –– отрезок по лучу
    /*
    Производный класс –– отрезок по лучу, начальная точка с координатами x,y,z,
    конечная точка находится на расстоянии A от начальной по лучу, проходящему 
    через начало координат и начальную точку
    */
    class P_A : Point // P_A –– наследник Point
    {
        /*
        (a) В производном классе добавляется указанное поле
        private и 2 метода public Get, Put для работы с этим полем
        */
        private float A;
        public float GetA()
        {
            return A;
        }
        public void PutA(float a)
        {
            A = a;
        }

        /*
	    (c) Метод базового класса перегружается для производного
	    с учетом нового поля, при этом базовый метод не вызывается,
	    а доступ к полям базового класса обеспечивает модификатор protected
	    */
        // Перегруженный метод в производном классе
        public float OP()
        {
            /*
        	Расстояние от отрезка до начала координат –– это
    	    расстояние от середины отрезка
    	    */
            // OP = (sqrt((X-X0)*(X-X0) + (Y-Y0)*(Y-Y0) + (Z-Z0)*(Z-Z0))) + A/2 =>
            return (float)Math.Round(Math.Sqrt(X * X + Y * Y + Z * Z) + (A / 2), 3);
            // Доступ есть: X, Y, Z –– protected
        }

        /*
	    (d) Выполняется перегрузка функций Init, Display для
	    производного класса с вызовом функции базового класса
	    */
        public void Init(float x, float y, float z, float a)
        {
            base.Init(x, y, z);  // Вызов базового метода
            A = a;
        }
        public void Display()
        {
            base.Display(); // Вызов базового метода
            Console.WriteLine("Расстояние от начальной точки по лучу, проходящему через ");
            Console.WriteLine("начало координат и начальную точку (длина отрезка): " + A + "\n");
        }

        // (e)
        // Вызов конструктора базового класса в заголовке
        public P_A(float x, float y, float z, float a) : base(x, y, z)
        {
            A = a;
        }
    }
}