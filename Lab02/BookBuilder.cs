namespace Lab02;

public class BookBuilder : IBookBuilder
{
    private string _title;
    private string _author;
    private List<string> _genres;
    private DateTime _publicationDate;
    private string _annotation;
    private string _isbn;
    private List<string> _tags;

    public IBookBuilder SetTitle(string title)
    {
        _title = title;
        return this;
    }

    public IBookBuilder SetAuthor(string author)
    {
        _author = author;
        return this;
    }

    public IBookBuilder SetGenres(IEnumerable<string> genres)
    {
        _genres = genres.ToList();
        return this;
    }

    public IBookBuilder SetISBN(string isbn)
    {
        _isbn = isbn;
        return this;
    }

    public IBookBuilder SetPublicationDate(DateTime date)
    {
        _publicationDate = date;
        return this;
    }

    public IBookBuilder SetAnnotation(string annotation)
    {
        _annotation = annotation;
        return this;
    }

    public IBookBuilder SetTags(IEnumerable<string> tags)
    {
        _tags = tags.ToList();
        return this;
    }

    public Book Build()
    {
        return new Book(_title, _author, _genres, _publicationDate, _annotation, _isbn, _tags);
    }
}