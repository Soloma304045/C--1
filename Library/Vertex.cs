namespace Library
{
    /// <summary>
    /// класс, представляющий вершину из X и Y координат.
    /// </summary>
    public class Vertex
    {
        /// <summary>
        /// X-координата вершины.
        /// </summary>
        public int xCord;
        /// <summary>
        /// Y-координата вершины.
        /// </summary>
        public int yCord;

        /// <summary>
        /// Конструктор класса Vertex.
        /// </summary>
        /// <param name="xCord">X-координата вершины.</param>
        /// <param name="yCord">Y-координата вершины.</param>
        public Vertex(int xCord, int yCord)
        {
            this.xCord = xCord;
            this.yCord = yCord;
        }
        
        /// <summary>
        /// вывод информации о вершинаъ.
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"X - {xCord}  Y - {yCord}");
        }
    }
}