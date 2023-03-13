using Moq;

namespace Task_3_1.Tests
{
    [TestFixture]
    public class UserRepositoryTests
    {
        [Test]
        public void UserRepositoryMustReturnAllUsers()
        {
            var mockUsers = new Mock<IUserRepository>;
            mockUsers.Setup(u => u.FindAll()).Returns();
        }
    }
}