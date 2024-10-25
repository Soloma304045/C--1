    public class Parallelogram(Vertex a, Vertex b, Vertex c, Vertex d)
    {
        public Vertex a = a;
        public Vertex b = b;
        public Vertex c = c;
        public Vertex d = d;
        public double ab = -1;
        public double cd = -1;
        public double ac = -1;
        public double bd = -1;
        public double area = -1;
        public int height = -1;
        public int perimeter = -1;
        public bool ItExist()
        {
            if(a.yCord == b.yCord && c.yCord == d.yCord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void FindSideLengths()
        {
            ab = b.xCord - a.xCord;
            cd = d.xCord - c.xCord;
            ac = Math.Pow(Math.Pow((double)Math.Abs(a.xCord - c.xCord), (double)2) + Math.Pow((double)(a.yCord - c.yCord), (double)2), (double)0.5);
            bd = Math.Pow(Math.Pow((double)Math.Abs(b.xCord - d.xCord), (double)2) + Math.Pow((double)(b.yCord - d.yCord), (double)2), (double)0.5);
        }
        public void FindArea()
        {
            height = a.yCord - c.yCord;
            area = height * cd;
        }
        public void FindPerimeter()
        {
            perimeter = (int)(ab + cd + ac + bd);
        }

        public void DotExam(int xCord, int yCord)
        {
            bool[] vectors = new bool[4];
            int FindVector(int x0, int y0, int xA, int yA, int xB, int yB)
            {
                return (xA - x0) * (yB - y0) - (yA - y0) * (xB - x0);
            }
            vectors[0] = FindVector(xCord, yCord, a.xCord, a.yCord, b.xCord, b.yCord) >= 0;
            vectors[1] = FindVector(xCord, yCord, b.xCord, b.yCord, c.xCord, c.yCord) >= 0;
            vectors[2] = FindVector(xCord, yCord, c.xCord, c.yCord, d.xCord, d.yCord) >= 0;
            vectors[3] = FindVector(xCord, yCord, d.xCord, d.yCord, a.xCord, a.yCord) >= 0;
            if (vectors[0] && vectors[1] && vectors[2] && vectors[3])
            {
                Console.WriteLine("Точка внутри фигуры");
            }
            else
            {
                Console.WriteLine("Точка вне фигуры");
            }
        }
        public void Print()
        {
            a.Print();
            b.Print();
            c.Print()
            d.Print();

            if(this.ItExist())
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