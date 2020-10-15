using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            User me = new User("Desktop", "Vlad", "Sergienko", 18, "18.09.2020");
            me.Print();
        }
    }
}
