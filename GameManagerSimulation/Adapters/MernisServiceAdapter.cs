using GameManagerSimulation.Abstract;
using GameManagerSimulation.Entities;
using GameManagerSimulation.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSimulation.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(),gamer.DateOfBirth.Year);
        }
    }
}
