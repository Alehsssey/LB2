using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Content
    {
        string _content = "Story about detective named Sherlock Holmes";
        public void Show()
        {
            Console.ResetColor();
            Console.Write("Content: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_content);
            Console.ResetColor();
        }
    }
}
