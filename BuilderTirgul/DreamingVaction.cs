using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTirgul
{
    internal class DreamingVaction : VactionBuilder
    {
        
        public override void BuildFlyType()
        {
            vaction.SetFlyType("direct flight");
        }

        public override void BuildStarsHotel()
        {
            vaction.SetStarsHotel(5);
        }

        public override void BuildTransportation()
        {
            vaction.SetTrans("Taxi");
        }
    }
}
