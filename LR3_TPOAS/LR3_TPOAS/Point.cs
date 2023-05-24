using System;

namespace LR_6._1_С_sharp__STP
{
    /// <summary>
    /// <brief> Базовый класс "Точка" </brif>
    /// <details> Данный класс нужен для хранения и 
    /// обработки информации об одной точке </details>
    /// </summary>
    class Point
    {
        // Поля класса (наследуемые)
        protected float X, Y, Z; // Координаты

        // Методы класса (открытые)
        /// <summary>
        /// Пустой конструктор без параметров класса Point
        /// </summary>
        public Point()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        /// <summary>
        /// Конструктор класса Point, инициализирующий координаты точки
        /// </summary>
        /// <param name="x"> Координата по оси X </param>
        /// <param name="y"> Координата по оси Y </param>
        /// <param name="z"> Координата по оси Z </param>
        /// ![Image](D:/Study programs/Doxygen/Projects/LR3_TPOAS/Point.jpg)
        public Point(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Вызывается для ввода пользователем координат точки 
        /// </summary>
        public void Init(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Выводит данные о точке в консоль
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Точка с координатами: (" + X + "; " + Y + "; " + Z + ")");
        }

        /// <summary>
        /// Считает расстояние от точки до начала координат
        /// Формула:
        /// \f$ OP = \sqrt{(X-X0)^2+(Y-Y0)^2+(Z-Z0)^2} \f$
        /// </summary>
        /// <returns></returns>
        public float OP()
        {
            // OP = sqrt((X-X0)*(X-X0) + (Y-Y0)*(Y-Y0) + (Z-Z0)*(Z-Z0)) =>
            return (float)Math.Round(Math.Sqrt((X * X + Y * Y + Z * Z)), 3);
        }
    }

    /// <summary>
    /// <brief> Производный класс "Отрезок по лучу" </brief>
    /// <author> Lianka_VI </author> 
    /// <version> 1.9 </version> 
    /// <date> May 2023 </date>
    /// <warning> Данный класс создан в учебных целях </warning> 
    /// Обычный дочерний класс, который унаследован от ранее созданного класса Point
    /// </summary>
    /*
    Производный класс –– отрезок по лучу, начальная точка с координатами x,y,z,
    конечная точка находится на расстоянии A от начальной по лучу, проходящему 
    через начало координат и начальную точку
    */
    class P_A : Point
    {
        private float A; // Длина отрезка

        /// <summary>
        /// Получает длину отрезка
        /// </summary>        
        public float GetA()
        {
            return A;
        }

        /// <summary>
        /// Задаёт длину отрезка
        /// </summary>  
        public void PutA(float a)
        {
            A = a;
        }

        /*
	    Метод базового класса перегружается для производного
	    с учетом нового поля, при этом базовый метод не вызывается,
	    а доступ к полям базового класса обеспечивает модификатор protected
	    */
        /// <summary>
        /// Пергруженный метод OP базового класса Point
        /// Считает расстояние от отрезка до начала координат
        /// Формула:
        /// \f$ OP = \sqrt{(X-X0)^2+(Y-Y0)^2+(Z-Z0)^2}+A/2 \f$
        /// </summary>
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
        
        /// <summary>
        /// Пергруженный метод Init базового класса Point
        /// Вызывается для ввода пользователем координат точки и длины отрезка
        /// </summary>
        public void Init(float x, float y, float z, float a)
        {
            base.Init(x, y, z);  // Вызов базового метода
            A = a;
        }

        /// <summary>
        /// Пергруженный метод Display базового класса Point
        /// Выводит данные о точке и длине отрезка в консоль
        /// </summary>
        public void Display()
        {
            base.Display(); // Вызов базового метода
            Console.WriteLine("Расстояние от начальной точки по лучу, проходящему через ");
            Console.WriteLine("начало координат и начальную точку (длина отрезка): " + A + "\n");
        }
        
        /// <summary>
        /// Конструктор класса P_A, вызывающий конструктор базового класса Point и
        /// дополнительно инициализирующий длину отрезка
        /// </summary>
        /// <param name="x"> Координата по оси X </param>
        /// <param name="y"> Координата по оси Y </param>
        /// <param name="z"> Координата по оси Z </param>
        /// <param name="A"> Длина отрезка </param>
        /// ![Image](D:/Study programs/Doxygen/Projects/LR3_TPOAS/A.PNG)
        public P_A(float x, float y, float z, float a) : base(x, y, z)
        {
            A = a;
        }
    }
}