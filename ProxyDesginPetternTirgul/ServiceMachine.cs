using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesginPetternTirgul
{
    internal class ServiceMachine : IServiceMachine
    {
        private InteriorOffice intoffec;
        public ServiceMachine(InteriorOffice intofc)
        {
            this.intoffec = intofc;
        }
        public void RenewalPassport()
        {
            intoffec.RenewalPassport();
        }

        public void SetAdress(string address)
        {
            intoffec.SetAdress(address);
        }
    }
}
