using GameManagerSimulation.Abstract;
using GameManagerSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSimulation.Concrete
{
    public class GameManager : BaseGameManager
    {
        public override void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            base.Sale(gamer, game, campaign);

        }
        public override void Add(Game game)
        {
            base.Add(game);
        }

        public override void Update(Game game)
        {
            base.Update(game);
        }

        public override void Delete(Game game)
        {
            base.Delete(game);
        }
    }
}
