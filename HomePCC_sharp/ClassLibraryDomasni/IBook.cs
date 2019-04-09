using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDomasni
{
    
        public interface IBook
        {
            int ID { get; set; }
            string Tittle { get; set; }
            EditionType TypesOfEdition { get; set; }
            int NumberOfPages { get; set; }
            Type Type { get; set; }
            long GenerateISBN();


        }



        public enum EditionType
        {
            Hardcover,
            Paperback,
            EBook,
            AudioBook
        }
        public enum Type
        {
            Novela,
            StoryCollection,
            Anthology
        }



    
}
