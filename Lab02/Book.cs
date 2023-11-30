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
        public string Title { get; set; }

        public string Author { get; set; }

        public List<string> Genres { get; set; }

        public DateTime PublicationDate { get; set; }

        public string Annotation { get; set; }

        public string ISBN { get; set; }

        public List<string> Tags { get; set; }


        public override string ToString() //преобразует в строку введенные данные (названия, автора, номер + добавит by) и выведет на экран 
        {
            return $"{Title} by {Author}, ISBN: {ISBN}"; //выводится при поиске книги
        }
    }


}

