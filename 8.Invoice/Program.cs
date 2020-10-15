using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(12345, "Ivan Ivanov", "Ikea");
            invoice.Price();
        }
    }
}
