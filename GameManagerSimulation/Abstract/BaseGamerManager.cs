using GameManagerSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSimulation.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine("Gamer Saved: " + gamer.FirstName);
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated: " + gamer.FirstName);
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted: " + gamer.FirstName);
        }
    }
}
