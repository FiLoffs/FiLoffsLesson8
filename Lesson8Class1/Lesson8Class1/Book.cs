using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Class1
{
    class Book
    {
        string title;
        string []authors;
        string puplisher;
        ushort pages;
        ushort year;

        public string Title { get => title; set => title = value; }
        public string Authors { get => authors; set => authors = value; }
        public string Puplisher { get => puplisher; set => puplisher = value; }
        public ushort Pages { get => pages; set => pages = value; }
        public ushort Year { get => year; set => year = value; }

        public Book(string title, string authors, string puplisher, ushort pages, ushort year)
        {
            this.title = title;
            this.authors = authors;
            this.puplisher = puplisher;
            this.pages = pages;
            this.year = year;
        }
    }
    




}
