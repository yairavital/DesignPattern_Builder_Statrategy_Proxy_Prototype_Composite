using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuliderDesignPattern
{
    internal class House
    {
        private string basement;
        private string structure;
        private string interior;
        private string roof;

        public void SetBasement(string basem)
        {
            this.basement = basem;
        }
        public void SetStructure(string structure)
        {
            this.structure = structure;
        }
        public void SetInterior(string inter)
        {
            this.interior = inter;
        }
        public void SetRoof(string roof)
        {
            this.roof = roof;
        }
        public override string ToString()
        {
            return roof + " " + basement;
        }
    }
}
