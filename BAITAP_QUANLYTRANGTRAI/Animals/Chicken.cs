using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAITAP_QUANLYTRANGTRAI.Foods;

namespace BAITAP_QUANLYTRANGTRAI.Animals
{
    internal class Chicken : FarmAnimal
    {
        public Chicken()
        {
            Name = Constains.CHICKEN_NAME;

            EatFood = new Corn();
        }
    }
}
