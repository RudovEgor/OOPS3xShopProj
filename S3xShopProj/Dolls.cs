using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3xShopProj
{
    internal class Dolls : Product
    {
        public string Material { get; private set; }
        public Dolls(string nameOfProduct, int price,  string manufacturer,string material) : base(nameOfProduct, price, manufacturer)
        {
            Material = material;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Материал продукта: {Material}");
        }
    }
}
