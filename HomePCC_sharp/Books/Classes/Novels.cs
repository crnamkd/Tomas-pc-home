using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Classes
{
    public class Novels : IBook
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public List<Novels> Series { get; set; }
        public Type Type { get; set; }
        public EditionType TypeOfEdition { get; set; }
        public int NumberOfPages { get; set; }
        public int SeriesNumber { get; set; }
        public int ID { get; set; }
        public bool IsItSeries { get; set; }

        public override string ToString()
        {
            string series = " ";
            if (SeriesNumber > 0)
            {
                foreach (var str in Series)
                {
                    series += $"\n{str.Title}";
                }
            }
            else series = "The novel you are looking has no serial !!!";
            return $"Author : {Author}  Title : {Title} Number of pages : {NumberOfPages} \nSerials : {series}Number of series : {SeriesNumber} ";
        }

        public Novels(string author, string title, EditionType edition, int numberofpages, bool isitseries)
        {
            {
                Type = Type.Novela;
                Author = author;
                Title = title;
                Series = new List<Novels>();
                TypeOfEdition = edition;
                IsItSeries = isitseries;
                NumberOfPages = numberofpages;
                ID = GetHashCode();
            }
        }

        public long GenerateISBN()
        {
            long isbn = 0;

            Random random = new Random();

            for (int i = 0; i < 13; i++)
            {
                isbn += (long)(Math.Pow(10, i) * random.Next(1, 10));
            }
            return isbn;
        }

        public void AddToSeries(Novels novel)
        {
            if (novel.IsItSeries)
            {
                Series.Add(novel);
                SeriesNumber++;
            }
            else
                throw new ArgumentException("This is a Novel without a serial ! ");
        }
    }
}

