namespace TicTacToe.Logic
{
    public class Cell
    {
        public Cell(int row, int column, Marker marker)
        {
            Row = row;
            Column = column;
            Marker = marker;
        }

        public int Row { get; }
        public int Column { get; }
        public Marker Marker { get; }
    }
}