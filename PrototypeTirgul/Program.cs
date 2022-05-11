using PrototypeTirgul;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Customer cust = new Customer("Dan",34);
Biil bill = new Biil(cust,23,2);
Biil bill2 = bill.Clone();
bill2.price = 50;
Console.WriteLine(bill.price);
