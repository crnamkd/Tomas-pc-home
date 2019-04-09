using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDomasni
{
    class StoryCollection : IBook
    {
        public string Author { get; set; }
        public List<StoryCollection> StoryCollections { get; set; }
        public int ID { get; set; }
        public string Tittle { get; set; }
        public EditionType TypeOfEdition { get; set; }
        public int NumberOfPages { get; set; }
        public Type Type { get; set; }
        public EditionType TypesOfEdition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public StoryCollection(string tittle, EditionType type, int num, string author)
        {
            ID = GetHashCode();
            Tittle = tittle;
            TypeOfEdition = type;
            NumberOfPages = num;
            Author = author;
            StoryCollections = new List<StoryCollection>();
            Type = Type.StoryCollection;
        }

        public void AddStory(StoryCollection story)
        {
            StoryCollections.Add(story);
        }

        public override string ToString()
        {
            return $"Tittle : {Tittle} Author:{Author} Number of stories : {StoryCollections.Count} ";
        }


        public long GenerateISBN()
        {
            long isbn = 0;

            Random random = new Random();

            for (int i = 0; i < 14; i++)
            {
                isbn += (long)(Math.Pow(10, i) * random.Next(1, 10));
            }
            return x;
        }
    }
}
