using System.Collections.Generic;
using System.Linq;

namespace TicTacToe.Logic
{
    public class Board
    {
        public Board()
        {
            var cells = CreateCells();

            Cells = cells;
        }

        private Board(IEnumerable<Cell> cells)
        {
            Cells = cells;
        }

        public Board Clone(Cell cell)
        {
            var cells = CreateCells()
                .Select(x => x.Row == cell.Row && x.Column == cell.Column ? x : new Cell(cell.Row, cell.Column, cell.Marker))
                .ToList();
                
            return new Board(cells);
        }

        public IEnumerable<Cell> Cells { get; }

        private static IEnumerable<Cell> CreateCells()
        {
            var cells = new List<Cell>();

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    cells.Add(new Cell(i, j, Marker.None));
                }
            }

            return cells;
        }
    }
}