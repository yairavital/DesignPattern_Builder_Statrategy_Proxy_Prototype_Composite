using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeTirgul
{
    public class Customer: IProto<Customer>
    {
        public string Name { get; set; }
        public int id;

        public Customer(string Name,int id)
        {
            Name = Name;
            id = id;
        }
        public Customer Clone()
        {
            return new Customer(this.Name, this.id);
        }
    }
}
