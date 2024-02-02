using GameManagerSimulation.Abstract;
using GameManagerSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSimulation.Concrete
{
    public class GamerManager : BaseGamerManager
    {
        IGamerCheckService _validationService;

        public GamerManager(IGamerCheckService validationService)
        {
            _validationService = validationService;
        }

        public override void Save(Gamer gamer)
        {
            if (_validationService.CheckIfRealPerson(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
        }

        public override void Update(Gamer gamer)
        {
            base.Update(gamer);

        }

        public override void Delete(Gamer gamer)
        {
            base.Delete(gamer);

        }
    }
}
