using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Book
    {
        public void ShowAll()
        {
            Title a = new Title();
            a.Show();
            Author b = new Author();
            b.Show();
            Content c = new Content();
            c.Show();
        }
    }
}
