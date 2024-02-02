using GameManagerSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSimulation.Abstract
{
    public abstract class BaseGameManager : IGameService
    {
        public virtual void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " purchased the " + game.GameName + " game for  " + (game.GamePrice - (game.GamePrice * (campaign.Discount / 100))) + " liras with a " +
               campaign.Discount + " discount with the " + campaign.Name + " campaign.");
        }

        public virtual void Add(Game game)
        {
            Console.WriteLine("Game Added: " + game.GameName);
        }

        public virtual void Update(Game game)
        {
            Console.WriteLine("Game Updated: " + game.GameName);
        }

        public virtual void Delete(Game game)
        {
            Console.WriteLine("Game Deleted: " + game.GameName);
        }
    }
}
