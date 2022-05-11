using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTirgul
{
    internal class Vaction
    {
        private string transportation;// הסעה
        private int starsHotel;//מס כוכבים למלון
        private string flyType;//סוג הטיסה

        public void SetTrans(string tran)
        {
            transportation = tran;
        }
        public void SetStarsHotel(int stars)
        {
            starsHotel = stars;
        }
        public void SetFlyType(string type)
        {
            flyType = type;
        }
    }
}
