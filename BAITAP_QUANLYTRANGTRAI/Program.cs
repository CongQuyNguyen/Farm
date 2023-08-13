using System;
using System.Text;

namespace BAITAP_QUANLYTRANGTRAI
{
    internal class Program
    {

        static void Menu ()
        {
            
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            AllFarmAnimal farm = new AllFarmAnimal();

            farm.AddListAnimal("Con Bò", 12);
            farm.AddListAnimal("Con Heo", 6);
            farm.AddListAnimal("Con Gà", 40);
            farm.AddListAnimal("Con Chó", 2);

            farm.AllBillAnimal();

            farm.RemmoveListAnimal("Con Bò", 4);
            farm.AllBillAnimal();
        }
    }
}