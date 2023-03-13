using Moq;

namespace Task_3_2.Tests
{
    public class BookRepositoryTests
    {
        [Fact]
        public void BookRepositoryMustReturnAllBook()
        {
            List<Book> books = new List<Book>()
            {
                new Book(){Title = "Война и мир" },
                new Book(){Title = "Человек-невидимка" },
                new Book(){Title = "Анна Каренина" }
            };

            Mock<IBookRepository> mock = new Mock<IBookRepository>();
            mock.Setup(books => books.FindAll()).Returns(books);

            Assert.Contains(mock.Object.FindAll(), b => b.Title == "Война и мир");
            Assert.Contains(mock.Object.FindAll(), b => b.Title == "Человек-невидимка");
            Assert.Contains(mock.Object.FindAll(), b => b.Title == "Анна Каренина");

        }
    }
}