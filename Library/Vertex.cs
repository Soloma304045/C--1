namespace Library
{
    /// <summary>
    /// �����, �������������� ������� �� X � Y ���������.
    /// </summary>
    public class Vertex
    {
        /// <summary>
        /// X-���������� �������.
        /// </summary>
        public int xCord;
        /// <summary>
        /// Y-���������� �������.
        /// </summary>
        public int yCord;

        /// <summary>
        /// ����������� ������ Vertex.
        /// </summary>
        /// <param name="xCord">X-���������� �������.</param>
        /// <param name="yCord">Y-���������� �������.</param>
        public Vertex(int xCord, int yCord)
        {
            this.xCord = xCord;
            this.yCord = yCord;
        }
        
        /// <summary>
        /// ����� ���������� � ��������.
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"X - {xCord}  Y - {yCord}");
        }
    }
}