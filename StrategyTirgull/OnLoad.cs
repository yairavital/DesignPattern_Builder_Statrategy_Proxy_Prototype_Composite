using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTirgull
{
    internal class OnLoad : ITurnTrafficLights
    {
        public bool IsTerfficWorks()
        {
            return true;
        }

        public void TurnTerfficTime()
        {
            Console.WriteLine("The terffic lights works every half a minute");
        }
    }
}
