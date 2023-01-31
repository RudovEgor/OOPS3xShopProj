using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3xShopProj
{
    internal class Aphrodisiacs : Product
    {
        public string Structure { get; private set; }
        public Aphrodisiacs(string nameOfProduct, int price,  string manufacturer,string structure) : base(nameOfProduct, price,  manufacturer)
        {
            Structure= structure;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Состав продукта: {Structure}");
        }
    }
}
