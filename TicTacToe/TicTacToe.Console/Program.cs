using TicTacToe.Logic;

namespace TicTacToe.Console
{
    static class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Player(new Agent(), Marker.Cross);
            var player2 = new Player(new Agent(), Marker.Circle);
            var state = new State(new Board(), player1.Marker);

            state = PlayRound(player1, state);
            state = PlayRound(player2, state);
        }

        private static State PlayRound(Player player, State previousState)
        {
            var agent = player.Agent;
            var board = previousState.Board;

            var move = agent.GetMove(previousState);

            var isValid = board.IsValid(move, player.Marker);
            var hasWinner = board.HasWinner();
            var newBoard = board.CreateWith(move);
            var newState = new State(newBoard, previousState.NextMoveMarker == Marker.Cross ? Marker.Circle : Marker.Cross);

            agent.Observe(previousState, newState, isValid);

            return newState;
        }
    }
}