using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTirgull
{
    internal class TrafficLightManagement
    {
        private ITurnTrafficLights turnTrafficLights;
      public TrafficLightManagement()
        {
            turnTrafficLights = GetTurnTrafficLights();
        }
        public ITurnTrafficLights GetTurnTrafficLights()
        {
            int hour = DateTime.Now.Hour;
            if (hour > 7 && hour < 17)
                turnTrafficLights = new OnDay();
            else
                turnTrafficLights = new OnLight();
            turnTrafficLights = IsLoad();
            return turnTrafficLights;
          
           

        } 
        public ITurnTrafficLights IsLoad()
        {
            Console.WriteLine("There is a load now? press 1 for yes and 2 for no");
            int isLoad = int.Parse(Console.ReadLine());
            switch (isLoad)
            {
                case 1:
                    turnTrafficLights = new OnLoad();
                    break;
                case 2:
                    break;
                default:
                    {Console.WriteLine("Enter num again");
                    IsLoad();
                    }
                    
                    break;
            }
            return turnTrafficLights;

        }
        public void Operate()
        {
           if( turnTrafficLights.IsTerfficWorks())
                Console.WriteLine("The traffic lights works now");
        
            
            turnTrafficLights.TurnTerfficTime();

        }
    }
}
