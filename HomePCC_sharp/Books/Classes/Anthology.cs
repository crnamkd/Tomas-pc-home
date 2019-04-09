using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Classes
{
    public class Anthology : IBook
    {
        public string Editor { get; set; }
        public string Theme { get; set; }
        public List<StoryAnthology> Stories { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
        public EditionType TypeOfEdition { get; set; }
        public int NumberOfPages { get; set; }
        public Type Type { get; set; }
        

        public Anthology(string editor, string theme, EditionType edition, int numberOfPages, string title)
        {
            Title = title;
            Editor = editor;
            Theme = theme;
            Stories = new List<StoryAnthology>();
            ID = GetHashCode();
            TypeOfEdition = edition;
            NumberOfPages = numberOfPages;
            Type = Type.Anthology;

        }
        public override string ToString()
        {
            return $"Title : {Title} \nEditor : {Editor} \nNumber of stories : {Stories.Count} \nNumber of contribution authros : {Stories.Count}";
        }
        public long GenerateISBN()
        {
            long isbn = 0;
            Random random = new Random();
            {
                for (int i = 0; i < 14; i++)
                {
                    isbn += (long)(Math.Pow(10, i) * random.Next(1, 10));
                }
            }
            return isbn;
        }
        public void AddStory(StoryAnthology story)
        {
            Stories.Add(story);
        }
    }
}
