#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
using Library;
/// <summary>
/// Главный класс для работы с параллелограммом.
/// </summary>t
class Program
{
    /// <summary>
    /// Входная точка программы.
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
            Console.WriteLine("1. Инициализировать параллелограмм");
            Console.WriteLine("2. Вывести информацию о параллелограмме");
            Console.WriteLine("3. Проверить принадлежность точки к параллелограмму");
            Console.WriteLine("4. Выход");

            input[0] = Console.ReadLine();

            if (input != null)
            {

                userChoice = int.Parse(input[0]);

                switch (userChoice)
                {
                    case 1:
                    {
                        Console.WriteLine("Введите координаты вершин параллелограма (x1, y1, x2, y2, x3, y3, x4, y4): ");
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
                            Console.WriteLine("Ошибка: Введено значение null.");
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
                        Console.WriteLine("Введите координаты точки (x, y): ");
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
                            Console.WriteLine("Ошибка: Введено значение null.");
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
                        Console.WriteLine("Ошибка: Введено некорректное значение.");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введено значение null.");
            }
        }
    }
}