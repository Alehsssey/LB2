using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Adress
    {
        private string index = "16900", country = "Украина", city = "Бахмач", street = "Соборности", house = "40", apartment = "6";
        public void Print()
        {
            Console.WriteLine("Индекс: " + index);
            Console.WriteLine("Страна: " + country);
            Console.WriteLine("Город: " + city);
            Console.WriteLine("Улица: " + street);
            Console.WriteLine("Дом: " + house);
            Console.WriteLine("Квартира: " + apartment);
        }
    }
}