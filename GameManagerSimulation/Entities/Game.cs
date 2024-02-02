using GameManagerSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSimulation.Entities
{
    public class Game : IEntity
    {
        public string GameName { get; set; }
        public int GamePrice { get; set; }
        public int DiscountRate { get; set; }
    }
}
