using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAITAP_QUANLYTRANGTRAI.Foods;

namespace BAITAP_QUANLYTRANGTRAI.Animals
{
    internal class Pig : FarmAnimal
    {
        public Pig()
        {
            Name = Constains.PIG_NAME;

            EatFood = new Bran();
        }
    }
}
