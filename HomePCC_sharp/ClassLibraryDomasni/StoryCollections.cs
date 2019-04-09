using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDomasni;

namespace ClassLibraryDomasni
{
    public class CollectionStory : IStory
    {
        public string Tittle { get; set; }
        public string Author { get; set; }
        public StoryType StoryType { get; set; }
        public bool IsOriginalToStoryCollection { get; set; }


        public CollectionStory(string tittle, StoryType type, bool isOriginal)
        {
            Tittle = tittle;
            StoryType = type;
            IsOriginalToStoryCollection = isOriginal;
        }


    }
}
}
