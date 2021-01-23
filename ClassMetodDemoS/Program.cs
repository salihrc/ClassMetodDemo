using System;
using System.Collections.Generic;

namespace ClassMetodDemoS
{
    class Program
    {
        static void Main(string[] args)
        { 
            string miktar = "0";
           
            AccountManager Metods = new AccountManager();
             
            CustomerType customer1 = new CustomerType();
            customer1.Name = "Ginepig";
            customer1.Surname = "Paşa";
            customer1.AccountBalance = 5000;

            List<CustomerType> customers = new List<CustomerType>();
            customers.Add(customer1);

            Console.WriteLine("Hesapın kullanıcısı : " + customers[0].Name + " " + customers[0].Surname + ". Hesabın Bakiyesi : " + customers[0].AccountBalance);
            Console.WriteLine("Eklemek istediğiniz miktarı giriniz.");
            miktar = Console.ReadLine();

            Metods.AccountMoneyAdd(customers[0].AccountBalance, Convert.ToInt32(miktar));
        }
    }
}
