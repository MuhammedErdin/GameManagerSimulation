using GameManagerSimulation.Abstract;
using GameManagerSimulation.Adapters;
using GameManagerSimulation.Concrete;
using GameManagerSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSimulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Save(new Gamer { DateOfBirth = new DateTime(2002, 9, 11), FirstName = "Muhammed", LastName = "Erdin", Id = 1, NationalityId = "17944305542" });
            Console.ReadLine();

            BaseGameManager gameManager = new GameManager();
            gameManager.Add(new Game { GameName = "Celese ", GamePrice = 600, DiscountRate = 10 });

            BaseCampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { Name = "Yılbaşı Kampanyası" });
        }
    }
}
