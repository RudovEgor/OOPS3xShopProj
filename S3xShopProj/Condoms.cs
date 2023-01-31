using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3xShopProj
{
    internal class Condoms : Product
    {
        public int Size { get; private set; }
        public Condoms(string nameOfProduct, int price,  string manufacturer,int size) : base(nameOfProduct, price,  manufacturer)
        {
            Size= size;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Размер продукта: {Size}");
        }
    }
}
