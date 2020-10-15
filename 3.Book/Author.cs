using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Author
    {
        string _author = "Arthur Conan Doyle";
        public void Show ()
        {
            Console.ResetColor();
            Console.Write("Author: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(_author);
        }
    }
}
