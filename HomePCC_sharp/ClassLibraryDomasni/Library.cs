using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDomasni
{
    public class Library
    {
        public string Name { get; set; }
        public List<IBook> Books { get; set; }


        public Library(string name)
        {
            Name = name;
            Books = new List<IBook>();
        }

        public void AddBook(IBook book)
        {
            Books.Add(book);
        }
    }
}
