namespace Library
{
    /// <summary>
    /// �����, �������������� ������� �� X � Y ���������.
    /// </summary>
    /// <param name="xCord">X-���������� �������.</param>
    /// <param name="yCord">Y-���������� �������.</param>
    public class Vertex(int xCord, int yCord)
    {
        /// <summary>
        /// X-���������� �������.
        /// </summary>
        public int xCord = xCord;
        /// <summary>
        /// Y-���������� �������.
        /// </summary>
        public int yCord = yCord;

        /// <summary>
        /// ����� ���������� � ��������.
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"X - {xCord}  Y - {yCord}");
        }
    }
}