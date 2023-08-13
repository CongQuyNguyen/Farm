using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP_QUANLYTRANGTRAI.Foods
{
    internal class Food
    {
        private string name;

        public string Name { get { return name; } set { name = value; } }

        private double price;

        public double Price { get { return price; } set { price = value; } }

        public double Amount(double weight) => price * weight;
    }
}
