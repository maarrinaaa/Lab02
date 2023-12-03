using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//[Serializable]
namespace Lab02
{
    public class Book //что включает книга, название, автор и тд
    {
        public Book(string title, string author, List<string> genres, DateTime publicationDate, string annotation, string isbn, List<string> tags)
        {
            Title = title;
            Author = author;
            Genres = genres;
            PublicationDate = publicationDate;
            Annotation = annotation;
            ISBN = isbn;
            Tags = tags;
        }
        public string Title { get; private set; }

        public string Author { get; private set; }

        public List<string> Genres { get; private set; }

        public DateTime PublicationDate { get; private set; }

        public string Annotation { get; private set; }

        public string ISBN { get; private set; }

        public List<string> Tags { get; private set; }


        public override string ToString() //преобразует в строку введенные данные (названия, автора, номер + добавит by) и выведет на экран 
        {
            return $"Книга найдена: {Title} by {Author}, ISBN: {ISBN}"; //выводится при поиске книги
        }
    }


}

