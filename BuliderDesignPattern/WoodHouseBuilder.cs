using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuliderDesignPattern
{
    internal class WoodHouseBuilder : HouseBulider
    {
        public override void BuildBasement()
        {
            house.SetBasement("Wooden Poles");

        }

        public override void BuildInterior()
        {
            house.SetInterior("Fire Woods");
        }

        public override void BuildRoof()
        {
            house.SetRoof("Wood, caribou and seal skins");
        }

        public override void BuildStructur()
        {
            house.SetStructure("Wood Logs");
        }
    }
}
