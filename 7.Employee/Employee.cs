using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Employee
    {
        string Name, Lastname;
        public Employee (string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
        }
        public void Info()
        {
            double salary = 10000;
            double tax = 33;
            double IncreaseForPost = 30;
            double IncreaseForExp3 = 20;
            Console.WriteLine("Выберите должность:");
            Console.WriteLine("1. Уборщик");
            Console.WriteLine("2. Старший уборщик");
            Console.WriteLine("3. Менеджер уборщиков");
            Console.WriteLine("4. Глава департамента уборщиков");
            int post = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стаж работы:");
            int exp = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < post; i++)
            {
                if (post <= 4 || post>0)
                {
                    salary += (salary * IncreaseForPost / 100);
                }
                else
                {
                    break;
                }
            }
            int IncreasesPerExp = exp / 3;
            for (int i =1; i<IncreasesPerExp;i++)
            {
                salary += (salary * IncreaseForExp3 / 100);
            }
            salary -= (salary * tax / 100);
            Console.WriteLine("Сотрудник " + Name + " " + Lastname + " получает зарплату: " + salary + " грн с налогом в: " + tax + " %");
        }
    }
}
