using Moq;

namespace Task_3_1.Tests
{
    [TestFixture]
    public class UserRepositoryTests
    {
        [Test]
        public void UserRepositoryMustReturnAllUsers()
        {
            List<User> users = new List<User>()
            { 
                new User() { Name = "Антон" },
                new User() { Name = "Иван" },
                new User() { Name = "Алексей" }
            };

            Mock<IUserRepository> mock = new Mock<IUserRepository>();
            mock.Setup(u => u.FindAll()).Returns(users);

            Assert.That(mock.Object.FindAll().Any(u => u.Name == "Антон"));
            Assert.That(mock.Object.FindAll().Any(u => u.Name == "Иван"));
            Assert.That(mock.Object.FindAll().Any(u => u.Name == "Алексей"));

        }
    }
}