using TicTacToe.Logic;

namespace TicTacToe.Console
{
    class Player
    {
        public Player(Agent agent, Marker marker)
        {
            Agent = agent;
            Marker = marker;
        }

        public Agent Agent { get; set; }
        public Marker Marker { get; set; }
    }
}