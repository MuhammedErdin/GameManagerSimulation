using GameManagerSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSimulation.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {
        public virtual void Add(Campaign campaign)
        {
            Console.WriteLine("Game Added: " + campaign.Name);
        }

        public virtual void Update(Campaign campaign)
        {
            Console.WriteLine("Game Updated: " + campaign.Name);
        }

        public virtual void Delete(Campaign campaign)
        {
            Console.WriteLine("Game Deleted: " + campaign.Name);
        }
    }
}
