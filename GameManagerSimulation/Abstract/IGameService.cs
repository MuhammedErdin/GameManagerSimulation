using GameManagerSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSimulation.Abstract
{
    interface IGameService
    {
        void Sale(Gamer gamer, Game game, Campaign campaign);
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
