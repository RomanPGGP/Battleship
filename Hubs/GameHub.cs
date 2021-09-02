using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using WebApplication1.Models;

namespace WebApplication1.Hubs
{
    public class GameHub : Hub
    {
        static public List<Player> players = new List<Player>();
        static public int ConnectedClients = 0;

        public async Task ConnectedUser(string user)
        {
            ConnectedClients++;

            Player UserInstance = new Player();

            players.Add(UserInstance);

            string x = Context.ConnectionId;

            if (ConnectedClients % 2 == 0)
            {
                players[ConnectedClients - 1].EnemyBoard = players[ConnectedClients - 2].SelfBoard;
                players[ConnectedClients - 2].EnemyBoard = players[ConnectedClients - 1].SelfBoard;
            }

            await Clients.All.SendAsync("ReceiveMessage", user, players.Count);
        }

    }
}
