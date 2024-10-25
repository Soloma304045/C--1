namespace Library
{
    /// <summary>
    /// ������������ ��������������, ������������ �������� ��������� � ���������� ����������������, ������ ��� �������, �������� � ����� ������.
    /// </summary>
    public class Parallelogram
    {
        /// <summary>
        /// ������ ������� ���������������.
        /// </summary>
        public Vertex a;
        /// <summary>
        /// ������ ������� ���������������.
        /// </summary>
        public Vertex b;
        /// <summary>
        /// ������ ������� ���������������.
        /// </summary>
        public Vertex c;
        /// <summary>
        /// ��������� ������� ���������������.
        /// </summary>
        public Vertex d;
        /// <summary>
        /// ����������� ������ Parallelogram
        /// <param name="a">������ �������.</param>
        /// <param name="b">������ �������.</param>
        /// <param name="c">������ �������.</param>
        /// <param name="d">��������� �������.</param>
        /// </summary>
        public Parallelogram(Vertex a, Vertex b, Vertex c, Vertex d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        
        /// <summary>
        /// ����� ������� AB.
        /// </summary>
        public double ab;

        /// <summary>
        /// ����� ��������������� ������� CD.
        /// </summary>
        public double cd;

        /// <summary>
        /// ��������� AC.
        /// </summary>
        public double ac;

        /// <summary>
        /// ��������� BD.
        /// </summary>
        public double bd;

        /// <summary>
        /// ������� ���������������.
        /// </summary>
        public double area;

        /// <summary>
        /// ������ ���������������.
        /// </summary>
        public int height;

        /// <summary>
        /// �������� ���������������.
        /// </summary>
        public int perimeter;

        /// <summary>
        /// ���������, ���������� �� ��������������, ����������� �� ������������ ������.
        /// </summary>
        /// <returns>���������� true, ���� �������������� ����������; ����� - false.</returns>
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
        /// ��������� ����� ������ � ���������� ��������������� �� ������ ��������� ������.
        /// </summary>
        public void FindSideLengths()
        {
            ab = b.xCord - a.xCord;
            cd = d.xCord - c.xCord;
            ac = Math.Pow(Math.Pow((double)Math.Abs(a.xCord - c.xCord), (double)2) + Math.Pow((double)(a.yCord - c.yCord), (double)2), (double)0.5);
            bd = Math.Pow(Math.Pow((double)Math.Abs(b.xCord - d.xCord), (double)2) + Math.Pow((double)(b.yCord - d.yCord), (double)2), (double)0.5);
        }

        /// <summary>
        /// ��������� ������� ���������������.
        /// </summary>
        public void FindArea()
        {
            height = a.yCord - c.yCord;
            area = height * cd;
        }

        /// <summary>
        /// ��������� �������� ���������������.
        /// </summary>
        public void FindPerimeter()
        {
            perimeter = (int)(ab + cd + ac + bd);
        }

        /// <summary>
        /// ����������, ��������� �� �������� ����� ������ ���������������.
        /// </summary>
        /// <param name="xCord">X-���������� �����.</param>
        /// <param name="yCord">Y-���������� �����.</param>
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
                Console.WriteLine("����� ������ ������");
            }
            else
            {
                Console.WriteLine("����� ��� ������");
            }
        }

        /// <summary>
        /// ������� ���������� � ��������, ��������, ������� � ��������� ���������������.
        /// </summary>
        public void Print()
        {
            a.Print();
            b.Print();
            c.Print();
            d.Print();

            if (this.ItExist())
            {
                Console.WriteLine("������ ����������");
            }
            else
            {
                Console.WriteLine("������ �� ����������");
            }

            Console.WriteLine($"AB - {ab}\nCD - {cd}\nAC - {ac}\nBD - {bd}");
            Console.WriteLine($"Area - {area}");
            Console.WriteLine($"Perimeter - {perimeter}");
        }
    }
}