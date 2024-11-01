#pragma warning disable CS8602 // ������������� ��������� ������ ������.
#pragma warning disable CS8604 // ��������, ��������-������, ����������� �������� NULL.
using Library;
/// <summary>
/// ������� ����� ��� ������ � ����������������.
/// </summary>t
class Program
{
    /// <summary>
    /// ������� ����� ���������.
    /// </summary>
    static void Main()
    {
        string[] input = new string[8];
        int count;
        int endIsNear = 0;
        int userChoice;
        Vertex aVert = new Vertex(0, 0);
        Vertex bVert = new Vertex(0, 0);
        Vertex cVert = new Vertex(0, 0);
        Vertex dVert = new Vertex(0, 0);

        Parallelogram parall = new Parallelogram(aVert, bVert, cVert, dVert);

        while (endIsNear == 0)
        {
            count = 0;
            Console.WriteLine("1. ���������������� ��������������");
            Console.WriteLine("2. ������� ���������� � ���������������");
            Console.WriteLine("3. ��������� �������������� ����� � ���������������");
            Console.WriteLine("4. �����");

            input[0] = Console.ReadLine();

            if (input != null)
            {

                userChoice = int.Parse(input[0]);

                switch (userChoice)
                {
                    case 1:
                    {
                        Console.WriteLine("������� ���������� ������ �������������� (x1, y1, x2, y2, x3, y3, x4, y4): ");
                        for (count = 0; count < 8; count++)
                        {
                            input[count] = Console.ReadLine() ?? "";
                        }
                        if (input != null)
                        {
                            aVert = new Vertex(int.Parse(input[0]), int.Parse(input[1]));
                            bVert = new Vertex(int.Parse(input[2]), int.Parse(input[3]));
                            cVert = new Vertex(int.Parse(input[4]), int.Parse(input[5]));
                            dVert = new Vertex(int.Parse(input[6]), int.Parse(input[7]));
                            parall = new Parallelogram(aVert, bVert, cVert, dVert);
                        }
                        else
                        {
                            Console.WriteLine("������: ������� �������� null.");
                        }
                        count = 0;
                        break;
                    }
                    case 2:
                    {
                        parall.FindSideLengths();
                        parall.FindPerimeter();
                        parall.FindArea();
                        parall.Print();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("������� ���������� ����� (x, y): ");
                        for (count = 0; count < 2; count++)
                        {
                            input[count] = Console.ReadLine() ?? "";
                        }
                        if (input != null)
                        {
                            parall.DotExam(int.Parse(input[0]), int.Parse(input[1]));
                        }
                        else
                        {
                            Console.WriteLine("������: ������� �������� null.");
                        }
                        count = 0;
                        break;
                    }
                    case 4:
                    {
                        endIsNear = 1;
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("������: ������� ������������ ��������.");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("������: ������� �������� null.");
            }
        }
    }
}