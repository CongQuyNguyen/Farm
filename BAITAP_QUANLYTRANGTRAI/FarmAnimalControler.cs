using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAITAP_QUANLYTRANGTRAI.Foods;
using BAITAP_QUANLYTRANGTRAI.Animals;

namespace BAITAP_QUANLYTRANGTRAI
{
    // Phần này đóng vai trò như một khu vựa nuôi riêng một loại động vật
    internal class FarmAnimalControler
    {
        private List<FarmAnimal> animals;

        public List<FarmAnimal> Animals { get { return animals; } set { animals = value; } }

        public FarmAnimalControler()
        {
            Animals = new List<FarmAnimal>();
        }

        // Hàm thêm một con trong danh sách
        public void AddAnimal (FarmAnimal animal)
        {
            Animals.Add(animal);
        }

        // Hàm xóa đi một con trong danh sách
        public void RemoveAnimal (FarmAnimal animal)
        {
            Animals.Remove(animal);
        }

        // Tính tiền thức ăn cho cả danh sách của 1 loài động vật
        public double BillAnimals (double weight)
        {
            if (Animals.Count > 0)
            {
                return Animals[0].EatFood.Amount(weight) * Animals.Count;
            }
            return 0;
        }

        public void PrintAnimals (double weight)
        {
            if (Animals.Count > 0)
            {
                Console.WriteLine($"{Animals.Count} {Animals[0].Name} mỗi ngày tiêu thụ hết {Animals.Count * weight}(kg) thức ăn và tiêu tốn {BillAnimals(weight)}(VND)");
            }
            else
            {
                Console.WriteLine("Không có dữ liệu");
            }
        }
    }
}
