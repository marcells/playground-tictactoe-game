namespace TicTacToe.Logic
{
    public class State
    {
        public State(Board board, Marker nextMoveMarkermarker)
        {
            Board = board;
            NextMoveMarker = nextMoveMarkermarker;
        }
        
        public Board Board { get; }
        
        public Marker NextMoveMarker { get; }
    }
}
