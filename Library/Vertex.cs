namespace Library
{
    /// <summary>
    /// класс, представляющий вершину из X и Y координат.
    /// </summary>
    /// <param name="xCord">X-координата вершины.</param>
    /// <param name="yCord">Y-координата вершины.</param>
    public class Vertex(int xCord, int yCord)
    {
        /// <summary>
        /// X-координата вершины.
        /// </summary>
        public int xCord = xCord;
        /// <summary>
        /// Y-координата вершины.
        /// </summary>
        public int yCord = yCord;

        /// <summary>
        /// вывод информации о вершинаъ.
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"X - {xCord}  Y - {yCord}");
        }
    }
}