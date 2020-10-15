using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Title
    {
        string _title = "Sherlock Holmes";
        public void Show ()
        {
            Console.Write("Title: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_title);
        }
    }
}
