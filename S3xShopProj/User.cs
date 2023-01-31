using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3xShopProj
{
    internal class User
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public int Balance { get; private set; }
        public int Spent { get; private set; }//потраченное бабло
        public User(string name,string address,int balance,int spent) 
        {
            Name = name;
            Address = address;
            Balance = balance;
            Spent = spent;
        }
        public void ShowUserInfo()
        {
            Console.WriteLine($"Добрый день, {Name}\nВаш баланс: {Balance}\nПотраченный денег: {Spent}\n\n");
        }
        public void ReduceBalance(int price) 
        {
            Balance -= price;
            Spent += price;
        }
    }
}
