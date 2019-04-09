using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Classes
{
    public interface IStory
    {
        string Title { get; set; }
        string Author { get; set; }
        StoryType StoryType { get; set; }
    }
    public enum StoryType
    {
        Novellete,
        Novela,
        ShortStory
    }
}
