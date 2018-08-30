using System;
using System.Linq;
using TicTacToe.Logic;

namespace TicTacToe.Console
{
    public static class BoardExtensions
    {
        public static bool IsValid(this Board board, Move move, Marker validMarker)
        {
            if (move.Marker != validMarker)
                return false;

            var cell = board.Cells.Single(x => x.Row == move.Row && x.Column == move.Column);

            return cell.Marker == Marker.None;
        }

        public static bool HasWinner(this Board board)
        {
            throw new InvalidOperationException();
        }

        public static Board CreateWith(this Board board, Move move)
        {
            return board.Clone(new Cell(move.Row, move.Column, move.Marker));
        }
    }
}