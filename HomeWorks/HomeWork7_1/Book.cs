namespace HomeWork7_1
{
    public class Book
    {
        public string Title { get; set; }
        public Genres Genre { get; set; }
        public Book(string title, Genres genres)
        {
            Title = title;
            Genre = genres;
        }

        public enum Genres
        {
            History,
            GraphicNovel,
            ShortStory,
            Biography,
            Romance
        }
    }
}