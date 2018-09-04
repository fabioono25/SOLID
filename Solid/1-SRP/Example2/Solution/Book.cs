using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._1_SRP.Example2.Solution
{
    public class Book
    {
        public string getTitle() => "a great title";

        public string getAuthor() => "a great title";

        public void turnPage() { }
    }

    //now we change responsibility of presentation outside Book class
    interface Printer
    {
        void printPage(string page);
    }

    public class PlainTextPrinter : Printer
    {
        public void printPage(string page)
        {
            Console.WriteLine("Print normal:"+page);
        }
    }

    public class HtmlPrinter : Printer
    {
        public void printPage(string page)
        {
            Console.WriteLine("Print for web:" + page);
        }
    }

    //to solve the problem of the persistence, we can split in one more class
    //now we can separate responsabilities and we'll be free to change the persistence methods without affect Book class
    public class SimplePersistence
    {
        public void save(Book book)
        {
            Console.WriteLine("Save the content");
        }
    }

    public class BookLocator
    {
        //reader will remain interested in Book class
        //librarian now have a class exclusively for managing book location
        public string getLocation(Book book) => "location of this in library";
    }
}
