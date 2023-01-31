using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3xShopProj
{
    internal class Informer
    {
        public void Information(User user, Product product)
        {
            double priceWithDiscount = product.GetDiscount(user);
            Console.WriteLine($"{user.Name} купил {product.NameOfProduct} за {priceWithDiscount}. Заказ отправлен по адресу {user.Address}\n\n");
            user.ReduceBalance(product.Price);
        }
    }
}
