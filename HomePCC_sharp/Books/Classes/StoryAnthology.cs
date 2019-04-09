using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Classes
{
    public class StoryAnthology : IStory
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public StoryType StoryType { get; set; }
        public bool IsItOriginal { get; set; }

        public StoryAnthology(string title, string author, StoryType type, bool original)
        {
            Title = title;
            Author = author;
            StoryType = type;
            IsItOriginal = original;
        }
    }
}
