namespace S3xShopProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            Informer informer = new Informer();
            User user = new User("Васек","Какой то адрес", 5000,0);
            Product[] products =
            {
                new Dolls("Кукла",4000,"Apple","Селикон"),
                new Aphrodisiacs("Афродизиак",1000,"Samsung","Таурин"),
                new Condoms("Презерватив",800,"Android",12),
            };
            while (isOpen)
            {
                user.ShowUserInfo();
                Console.WriteLine("Вот наш ассортимент:\n");
                for (int i = 0; i < products.Length; i++)
                {
                    Console.Write(i+1+" ");
                    products[i].ShowInfo();
                    Console.WriteLine(new String('-', 25));
                }
                Console.Write("Выберите продукт: ");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput <= products.Length && userInput >0)
                {
                    if (user.Balance > products[userInput-1].Price)
                    {
                        Console.WriteLine($"Вы выбрали: {products[userInput-1].NameOfProduct}");
                        informer.Information(user, products[userInput-1]);
                    }
                    else
                    {
                        Console.WriteLine("У вас не хватает средств\n\n");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("У нас нет такого продукта\nПопробуйте еще раз\n\n");
                }
                Console.WriteLine("Хотите что нибудь еще?\nY/N");

                if (Console.ReadLine().ToLower() == "n")
                {
                    isOpen = false;
                    break;
                }
                Console.Clear();
            }
        }
    }
}