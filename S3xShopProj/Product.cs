using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3xShopProj
{
    internal class Product
    {
        public string NameOfProduct { get; private set; }
        public int Price { get; private set; }
        public string Manufacturer { get; private set; }
        public Product(string nameOfProduct, int price, string manufacturer)
        {
            NameOfProduct = nameOfProduct;
            Price = price;
            Manufacturer = manufacturer;
        }
        public int GetDiscount(User user)
        {
            if (user.Spent>=1000)
            {
                return ((Price / 100)*10);
            }
            return Price;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Название продукта: {NameOfProduct}");
            Console.WriteLine($"Цена продукта: {Price} рублей");
            Console.WriteLine($"Производитель продукта: {Manufacturer}");
        }
    }
}
