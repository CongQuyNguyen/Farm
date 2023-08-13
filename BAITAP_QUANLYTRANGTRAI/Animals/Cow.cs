using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAITAP_QUANLYTRANGTRAI.Foods;

namespace BAITAP_QUANLYTRANGTRAI.Animals
{
    internal class Cow : FarmAnimal
    {
        public Cow()
        {
            Name = Constains.COW_NAME;

            EatFood = new Grass();
        }
    }
}
