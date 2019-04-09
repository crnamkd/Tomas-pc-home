using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Classes
{
    public static class Extension
    {
        public static List<IBook> GetBooks(this Library lib)
        {
            return lib.Books;
        }
    }
}
