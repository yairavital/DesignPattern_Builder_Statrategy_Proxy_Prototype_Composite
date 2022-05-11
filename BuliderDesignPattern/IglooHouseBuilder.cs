using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuliderDesignPattern
{
    internal class IglooHouseBuilder : HouseBulider
    {
        public override void BuildBasement()
        {
            house.SetBasement("Ice Bars");
        }

        public override void BuildInterior()
        {
            house.SetInterior("Ice Carvings");
        }

        public override void BuildRoof()
        {
            house.SetRoof("Ice Dome");
        }

        public override void BuildStructur()
        {
            house.SetStructure("Ice Blocks");
        }
        public override string ToString()
        {
            return house.ToString();
        }
    }
}
