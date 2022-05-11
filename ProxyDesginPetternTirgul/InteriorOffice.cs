using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesginPetternTirgul
{
    internal class InteriorOffice: IServiceMachine, IInteriorOffice
    {
        private string Address { get; set; } 
        private string name { get; set; }

        public void RenewalPassport()
        {
            Console.WriteLine("Your passport is renewal");
        }

        public void SetAdress(string address)
        {
            this.Address = address;
        }

        public void Health()
        {
            Console.WriteLine("Your health is ok");
        }

        public void SetName(string name)
        {
            this.name = name;
                }

        public string GetNAme()
        {
            return name;
        }

        public string GetAddress()
        {
            return Address;
        }
    }
}
