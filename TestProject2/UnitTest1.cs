
namespace Lab02.TestProject2
{
    public class UnitTest1
    {
        private List<Book> catalog;

        [SetUp]
        public void Setup()
        {
            catalog = new List<Book>();
        }

        [Test]
        public void AddBook_ShouldAddBookToCatalog()
        {
            // Arrange
            var book = new Book { Title = "Test Book", Author = "Test Author", ISBN = "1234567890" };

            // Act
            AddBookToCatalog(book);

            // Assert
            Assert.AreEqual(1, catalog.Count);
            Assert.AreEqual(book, catalog[0]);
        }

        [Test]
        public void SearchBooks_ByTitle_ShouldReturnMatchingBooks()
        {
            // Arrange
            var book1 = new Book { Title = "C#", Author = "John", ISBN = "1234567890" };
            var book2 = new Book { Title = "Python", Author = "Doe", ISBN = "0987654321" };
            catalog.AddRange(new List<Book> { book1, book2 });

            // Act
            var result = SearchByTitle("C#");

            // Assert
            CollectionAssert.Contains(result, book1);
            CollectionAssert.DoesNotContain(result, book2);
        }

        [Test]
        public void SaveAndLoadCatalogToJson_ShouldPreserveData()
        {
            // Arrange
            var book = new Book { Title = "Test Book", Author = "Test Author", ISBN = "1234567890" };
            AddBookToCatalog(book);

            // Assert
            Assert.AreEqual(1, catalog.Count);
            Assert.AreEqual(book, catalog[0]);
        }

        [Fact]
        public void Test1()
        {
            
        }
    }
}