using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Classes
{
    public class StoryCollection : IStory
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public StoryType StoryType { get; set; }
        public bool IsItOriginal { get; set; }
        public List<StoryCollection> CollectionOfStories { get; set; }


        public StoryCollection(string author, string title, StoryType type, bool original)
        {
            Title = title;
            StoryType = type;
            IsItOriginal = original;
        }
        
    }
}
