using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using BAITAP_QUANLYTRANGTRAI.Foods;

namespace BAITAP_QUANLYTRANGTRAI.Animals
{
    internal class Dog : FarmAnimal
    {
        public Dog()
        {
            Name = Constains.DOG_NAME;

            EatFood = new Meat();
        }
    }
}
