using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTirgul
{
    internal class LowCostVaction : VactionBuilder
    {
        public override void BuildFlyType()
        {
            vaction.SetFlyType("Connection flight");
        }

        public override void BuildStarsHotel()
        {
            vaction.SetStarsHotel(3);
        }

        public override void BuildTransportation()
        {
            vaction.SetTrans("Bus");
        }
    }
}
