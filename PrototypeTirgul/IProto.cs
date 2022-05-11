using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeTirgul
{
    internal interface IProto<T>
    {
        T Clone();
    }
}
