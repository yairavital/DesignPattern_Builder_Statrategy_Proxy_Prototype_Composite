using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeTirgul
{
    public class Biil : IProto<Biil>
    {
        public Customer customer1;
        public int price;
        public int vat;
        public DateTime time;
        public Biil(Customer customer, int price, int vat)
        {
            this.customer1 = customer;
            this.price = price;
            this.vat = vat;
            time = DateTime.Now;
        }

        public Biil Clone()
        {
            return new Biil(customer1.Clone(), price, vat);
        }
    }
}
