using System;

namespace WebApplication1.Models
{
    public class Player
    {
        /// <summary>
        /// Player username
        /// </summary>
        public string Username;

        /// <summary>
        /// Player usercode to find another players.
        /// </summary>
        public int UserCode;

        /// <summary>
        /// Battleship board to place and attack ships.
        /// </summary>
        public Battleship SelfBoard { get; set; }

        /// <summary>
        /// Battleship board for the enemy.
        /// </summary>
        public Battleship EnemyBoard { get; set; }

        /// <summary>
        /// Status for the synchronization with another players. SignalR.
        /// </summary>
        public int status { get; set; }                    // This can be offline 0 , online 1 (in lobby), playing 2.

        /// <summary>
        /// Constructor for the Player class.
        /// </summary>
        public Player()
        {
            Random UserCodeGen = new Random();
            SelfBoard = new Battleship();
            EnemyBoard = new Battleship();

            Username = "Captain Red Beard";
            UserCode = UserCodeGen.Next(10000, 99999);
            status = 1;
        }
    }
}
