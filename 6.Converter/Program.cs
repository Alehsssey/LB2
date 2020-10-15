using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(1, 1, 100, 34);
            converter.ValueConverter();
        }
    }
}
