using System.Collections.Generic;
using static HomeWork7_1.Book;

namespace HomeWork7_1
{
    public class Reader
    {
        public int Id { get; set; }

        public Dictionary<Genres, bool> subscribes = new Dictionary<Genres, bool>() { 
            { Genres.History, false },
            { Genres.GraphicNovel, false },
            { Genres.ShortStory, false },
            { Genres.Biography, false },
            { Genres.Romance, false }, };

        public Reader(int id)
        {
            Id = id;
        }

        public void Subscribe(Genres genre)
        {
            subscribes[genre] = true;
        }
    }
}