using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Invoice
    {
        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public int Account;
        public string Customer;
        public string Provider;

        string[] goods = { "Табуретка", "Стул", "Стол", "Кресло", "Диван", "Кровать", "Тумба", "Шкаф", "Дверь", "Лампа" };
        static int[] quality = { 15, 20, 0, 2, 7, 10, 0, 30, 4, 2 };

        const double tax = 20;

        public void Price()
        {
            double[] price = { 300, 350, 600, 1000, 5000, 10000, 500, 2999.99, 1499.99, 199.99 };

            Console.WriteLine($"Выберите номер товара, который хотите заказать:");
            for (int i = 0; i < goods.Length; i++)
                Console.WriteLine($"{i + 1}. {goods[i]} по цене: {price[i]} UAH\t*Осталось в наличии {quality[i]} штук*");
            int n = Convert.ToInt32(Console.ReadLine());

            if ((quality[n - 1] - 1) < 0)
            {
                Console.WriteLine($"\nТовара {goods[n - 1]} нет в наличии");
            }
            else
            {
                quality[n - 1]--;
                Console.WriteLine(
                    $"\nАккаунт: {Account}\n" +
                    $"Покупатель: {Customer}\n" +
                    $"Поставщик: {Provider}\n" +
                    $"Товар: {goods[n - 1]}\n" +
                    $"Цена: {price[n - 1]}\n" +
                    $"Цена с НДС: {(price[n - 1] * tax / 100) + price[n - 1]}");
            }
        }
    }
}
