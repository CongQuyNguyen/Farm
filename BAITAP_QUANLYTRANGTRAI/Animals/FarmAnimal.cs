using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAITAP_QUANLYTRANGTRAI.Foods;

namespace BAITAP_QUANLYTRANGTRAI.Animals
{
    // Là một loài động vực trong khu vựa nuôi của nó
    internal class FarmAnimal
    {
        private string name;

        public string Name { get { return name; } set { name = value; } }

        private Food eatFood;

        public Food EatFood { get {  return eatFood; } set {  eatFood = value; } }

    }
}
