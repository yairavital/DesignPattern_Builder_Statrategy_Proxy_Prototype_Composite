using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTirgul
{
    internal abstract class  VactionBuilder
    {
        protected Vaction vaction;
        public VactionBuilder()
        {
            vaction = new Vaction();
        }
        public abstract void BuildFlyType();
        public abstract void BuildStarsHotel();
        public abstract void BuildTransportation();
        public void CostructVaction()
        {
            BuildFlyType();
            BuildStarsHotel();
            BuildTransportation();
        }
        public Vaction GetVaction()
        {
            return vaction;
        }
    }
}
