using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuliderDesignPattern
{
    internal abstract class HouseBulider
    {
        protected House house;
        public HouseBulider()
        {
            house = new House();
        }

        public abstract void BuildBasement();
        public abstract void BuildStructur();
        public abstract void BuildInterior();
        public abstract void BuildRoof();
        public void ConstructHouse()
        {
            BuildBasement();
            BuildStructur();
            BuildInterior();
            BuildRoof();
        }
        public House GetHouse()
        {
            return house;
        }
    }
}
