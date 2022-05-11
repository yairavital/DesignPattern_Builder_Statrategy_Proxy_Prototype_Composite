using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesginPetternTirgul
{
    internal interface IInteriorOffice
    {
        void SetName(string name);
        void Health();
        string GetNAme();
        string GetAddress();
    }
}
