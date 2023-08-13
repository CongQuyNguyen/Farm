using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAITAP_QUANLYTRANGTRAI.Foods;
using BAITAP_QUANLYTRANGTRAI.Animals;
using System.Runtime.InteropServices;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace BAITAP_QUANLYTRANGTRAI
{
    // Quản lý toàn bộ các khu vựa nuôi trong nông trại
    internal class AllFarmAnimal
    {
        private FarmAnimalControler cow;
        public FarmAnimalControler Cow { get { return cow; } set { cow = value; } }

        private FarmAnimalControler chicKen;
        public FarmAnimalControler ChicKen { get { return chicKen; } set {  chicKen = value; } }

        private FarmAnimalControler dog;
        public FarmAnimalControler Dog { get { return dog; } set {  dog = value; } }

        private FarmAnimalControler pig;
        public FarmAnimalControler Pig { get { return pig; } set {  pig = value; } }


        // Hàm dựng ta sẽ khai báo từng khu vực (từng chuồng)
        public AllFarmAnimal ()
        {
            Cow = new FarmAnimalControler();

            ChicKen = new FarmAnimalControler();

            Dog = new FarmAnimalControler();

            Pig = new FarmAnimalControler();

        }

        public void AllBillAnimal ()
        {
            double sum = 0;
            sum += Cow.BillAnimals(Constains.FOOD_OF_COW_ADAY) + ChicKen.BillAnimals(Constains.FOOD_OF_CHICKEN_ADAY) +
                Dog.BillAnimals(Constains.FOOD_OF_DOG_ADAY) + Pig.BillAnimals(Constains.FOOD_OF_PIG_ADAY);

            Console.WriteLine("Các khoản tiền tiêu tốn trong hôm nay cho trang trại: ");
            Cow.PrintAnimals(Constains.FOOD_OF_COW_ADAY);
            ChicKen.PrintAnimals(Constains.FOOD_OF_CHICKEN_ADAY);
            Dog.PrintAnimals(Constains.FOOD_OF_DOG_ADAY);
            Pig.PrintAnimals(Constains.FOOD_OF_PIG_ADAY);

            Console.WriteLine("Tổng chi tiêu trong hôm nay: " + sum);
        }

        // Ta kiểm tra xem người dùng nhập vào con gì, sau đó tạo ra con đó và dựa vào số lượng
        // sẽ nhập vào danh sách của con đó
        private void Add (FarmAnimalControler farmAnimalControler, string name, int count)
        {
            FarmAnimal farmAnimal = new FarmAnimal();

            if (name.Equals (Constains.COW_NAME))
            {
                farmAnimal = new Cow();
            }
            else if (name.Equals(Constains.PIG_NAME))
            {
                farmAnimal = new Pig();
            }
            else if (name.Equals(Constains.CHICKEN_NAME))
            {
                farmAnimal = new Chicken();
            }
            else if (name.Equals(Constains.DOG_NAME))
            {
                farmAnimal = new Dog();
            }

            for (int i = 0; i < count; i++)
            {
                farmAnimalControler.AddAnimal(farmAnimal);
            }
        }

        // Chính thức thêm danh sách các con vừa rồi ra khỏi chuồng
        public void AddListAnimal (string animalName, int count)
        {
            if(animalName.Equals(Constains.COW_NAME))
            {
                Add(Cow, Constains.COW_NAME, count);
            }
            else if (animalName.Equals(Constains.PIG_NAME))
            {
                Add(Pig, Constains.PIG_NAME, count);
            }
            else if (animalName.Equals(Constains.CHICKEN_NAME))
            {
                Add(ChicKen, Constains.CHICKEN_NAME, count);
            }
            else if (animalName.Equals(Constains.DOG_NAME))
            {
                Add(Dog, Constains.DOG_NAME, count);
            }
        }


        private void Remove (FarmAnimalControler farmAnimalControler, string name, int count)
        {
            // Nếu như trong chuồng đó còn đủ số lượng con muốn xóa
            if (farmAnimalControler.Animals.Count >= count)
            {
                for (int i = 0; i < count; i++)
                {
                    if (name.Equals(Constains.COW_NAME))
                    {
                        farmAnimalControler.Animals.RemoveAt(0);
                    }
                    else if (name.Equals(Constains.PIG_NAME))
                    {
                        farmAnimalControler.Animals.RemoveAt(0);
                    }
                    else if (name.Equals(Constains.CHICKEN_NAME))
                    {
                        farmAnimalControler.Animals.RemoveAt(0);
                    }
                    else if (name.Equals(Constains.DOG_NAME))
                    {
                        farmAnimalControler.Animals.RemoveAt(0);
                    }
                }
            }
            // Trường hợp không số lượng con trong chuồng còn ít hơn số con muốn xóa
            else
            {
                farmAnimalControler.Animals.Clear();
            }
        }

        // Chính thức xóa danh sách các con vừa rồi ra khỏi chuồng
        public void RemmoveListAnimal (string animalName, int count)
        {
            if (animalName.Equals(Constains.COW_NAME))
            {
                Remove(Cow, Constains.COW_NAME, count);
            }
            else if (animalName.Equals(Constains.PIG_NAME))
            {
                Remove(Pig, Constains.PIG_NAME, count);
            }
            else if (animalName.Equals(Constains.CHICKEN_NAME))
            {
                Remove(ChicKen, Constains.CHICKEN_NAME, count);
            }
            else if (animalName.Equals(Constains.DOG_NAME))
            {
                Remove(Dog, Constains.DOG_NAME, count);
            }
        }
    }
}
