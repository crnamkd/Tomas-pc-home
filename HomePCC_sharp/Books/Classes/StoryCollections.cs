using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Classes
{
    public class StoryCollections : IBook
    {
        
            public string Author { get; set; }
            public List<StoryCollection> CollectionOfStories { get; set; }
            public int ID { get; set; }
            public string Title { get; set; }
            public EditionType TypeOfEdition { get; set; }
            public int NumberOfPages { get; set; }
            public Type Type { get; set; }

            public StoryCollections(string author, string title, EditionType type, int num)
            {
                ID = GetHashCode();
                Title = title;
                TypeOfEdition = type;
                NumberOfPages = num;
                Author = author;
                CollectionOfStories = new List<StoryCollection>();
                Type = Type.StoryCollection;
            }

            public void AddStory(StoryCollection story)
            {
                CollectionOfStories.Add(story);
            }

            public override string ToString()
            {
                return $"Title : {Title} Author:{Author} Number of stories : {CollectionOfStories.Count} ";
            }


            public long GenerateISBN()
            {
                long isbn = 0;

                Random random = new Random();

                for (int i = 0; i < 14; i++)
                {
                    isbn += (long)(Math.Pow(10, i) * random.Next(1, 10));
                }
                return isbn;
            
        }
    }
}