namespace Library
{
    /// <summary>
    /// Представляет параллелограмм, определенный четырьмя вершинами и различными характеристиками, такими как площадь, периметр и длины сторон.
    /// </summary>
    public class Parallelogram
    {
        /// <summary>
        /// Первая вершина параллелограмма.
        /// </summary>
        public Vertex a;
        /// <summary>
        /// Вторая вершина параллелограмма.
        /// </summary>
        public Vertex b;
        /// <summary>
        /// Третья вершина параллелограмма.
        /// </summary>
        public Vertex c;
        /// <summary>
        /// Четвертая вершина параллелограмма.
        /// </summary>
        public Vertex d;
        /// <summary>
        /// Конструктор класса Parallelogram
        /// <param name="a">Первая вершина.</param>
        /// <param name="b">Вторая вершина.</param>
        /// <param name="c">Третья вершина.</param>
        /// <param name="d">Четвертая вершина.</param>
        /// </summary>
        public Parallelogram(Vertex a, Vertex b, Vertex c, Vertex d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        
        /// <summary>
        /// Длина стороны AB.
        /// </summary>
        public double ab;

        /// <summary>
        /// Длина противоположной стороны CD.
        /// </summary>
        public double cd;

        /// <summary>
        /// Диагональ AC.
        /// </summary>
        public double ac;

        /// <summary>
        /// Диагональ BD.
        /// </summary>
        public double bd;

        /// <summary>
        /// Площадь параллелограмма.
        /// </summary>
        public double area;

        /// <summary>
        /// Высота параллелограмма.
        /// </summary>
        public int height;

        /// <summary>
        /// Периметр параллелограмма.
        /// </summary>
        public int perimeter;

        /// <summary>
        /// Проверяет, существует ли параллелограмм, основываясь на расположении вершин.
        /// </summary>
        /// <returns>Возвращает true, если параллелограмм существует; иначе - false.</returns>
        public bool ItExist()
        {
            if (a.yCord == b.yCord && c.yCord == d.yCord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Вычисляет длины сторон и диагоналей параллелограмма на основе координат вершин.
        /// </summary>
        public void FindSideLengths()
        {
            ab = b.xCord - a.xCord;
            cd = d.xCord - c.xCord;
            ac = Math.Pow(Math.Pow((double)Math.Abs(a.xCord - c.xCord), (double)2) + Math.Pow((double)(a.yCord - c.yCord), (double)2), (double)0.5);
            bd = Math.Pow(Math.Pow((double)Math.Abs(b.xCord - d.xCord), (double)2) + Math.Pow((double)(b.yCord - d.yCord), (double)2), (double)0.5);
        }

        /// <summary>
        /// Вычисляет площадь параллелограмма.
        /// </summary>
        public void FindArea()
        {
            height = a.yCord - c.yCord;
            area = height * cd;
        }

        /// <summary>
        /// Вычисляет периметр параллелограмма.
        /// </summary>
        public void FindPerimeter()
        {
            perimeter = (int)(ab + cd + ac + bd);
        }

        /// <summary>
        /// Определяет, находится ли заданная точка внутри параллелограмма.
        /// </summary>
        /// <param name="xCord">X-координата точки.</param>
        /// <param name="yCord">Y-координата точки.</param>
        public void DotExam(int xCord, int yCord) 
        {
            bool[] vectors = new bool[4];

             int FindVector(int x0, int y0, int xA, int yA, int xB, int yB)
            {
                return (xA - x0) * (yB - y0) - (yA - y0) * (xB - x0);
            }

            vectors[0] = FindVector(xCord, yCord, a.xCord, a.yCord, b.xCord, b.yCord) > 0;
            vectors[1] = FindVector(xCord, yCord, b.xCord, b.yCord, d.xCord, d.yCord) > 0;
            vectors[2] = FindVector(xCord, yCord, d.xCord, d.yCord, c.xCord, c.yCord) > 0;
            vectors[3] = FindVector(xCord, yCord, c.xCord, c.yCord, a.xCord, a.yCord) > 0;

            bool isInside = (vectors[0] == vectors[1]) && (vectors[1] == vectors[2]) && (vectors[2] == vectors[3]);

            if (isInside)
            {
                Console.WriteLine("Точка внутри фигуры");
            }
            else
            {
                Console.WriteLine("Точка вне фигуры");
            }
        }

        /// <summary>
        /// Выводит информацию о вершинах, сторонах, площади и периметре параллелограмма.
        /// </summary>
        public void Print()
        {
            a.Print();
            b.Print();
            c.Print();
            d.Print();

            if (this.ItExist())
            {
                Console.WriteLine("Фигура существует");
            }
            else
            {
                Console.WriteLine("Фигура не существует");
            }

            Console.WriteLine($"AB - {ab}\nCD - {cd}\nAC - {ac}\nBD - {bd}");
            Console.WriteLine($"Area - {area}");
            Console.WriteLine($"Perimeter - {perimeter}");
        }
    }
}