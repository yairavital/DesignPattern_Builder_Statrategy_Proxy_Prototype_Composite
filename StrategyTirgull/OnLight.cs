using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTirgull
{
    internal class OnLight : ITurnTrafficLights
    {
        public bool IsTerfficWorks()
        {
            return false;
        }

        public void TurnTerfficTime()
        {
            Console.WriteLine("The terrfic lights dosent works now.");
        }
    }
}
