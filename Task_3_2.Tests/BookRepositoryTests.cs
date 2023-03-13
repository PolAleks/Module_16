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
                new Book(){Title = "����� � ���" },
                new Book(){Title = "�������-���������" },
                new Book(){Title = "���� ��������" }
            };

            Mock<IBookRepository> mock = new Mock<IBookRepository>();
            mock.Setup(books => books.FindAll()).Returns(books);

            Assert.Contains(mock.Object.FindAll(), b => b.Title == "����� � ���");
            Assert.Contains(mock.Object.FindAll(), b => b.Title == "�������-���������");
            Assert.Contains(mock.Object.FindAll(), b => b.Title == "���� ��������");

        }
    }
}