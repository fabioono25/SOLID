using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._1_SRP.Example2.Violation
{
    /// <summary>
    /// We can think about two actors in this class: Books Administrator and the
    /// mechanism of data presentation (print)
    /// We have a mix of business logic with presentation logic
    /// </summary>
    public class Book
    {
        public string getTitle() => "a great title";

        public string getAuthor() => "a great title";

        public void turnPage() { }

        //another responsibility (other author)
        public void printCurrentPage() => Console.WriteLine("Printing current page");

        //object save and returns itself to presentation layer
        //authors: administation system or data persistence
        public void save() => Console.WriteLine("Save the content");

        //reader don't mind about book location
        //librarian will use this information
        public string getLocation() => "location of this in library";
    }
}
