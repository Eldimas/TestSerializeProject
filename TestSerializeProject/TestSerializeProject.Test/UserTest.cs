using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSerializeProject.Models;
using TestSerializeProject.Repository;

namespace TestSerializeProject.Test
{
    [TestClass]
    public class UserTest
    {

        [TestMethod]
        public void GetSerializeUser()
        {
            //Arrange
            var userRepository = new UserRepository();

            var user = new User();
            user.Id = 1;
            user.Name = "User name";
            //что-то добавил

            var extended = "{\"Id\":1,\"Name\":\"User name\"}";

            //Act
            var actual = userRepository.GetSerializeUser(user);
            //Assert
            Assert.AreEqual(extended, actual);
        }

        [TestMethod]
        public void GetDeserializeUser()
        {
            //Arrange
            var userRepository = new UserRepository();
            var userJson = "{\"Id\":1,\"Name\":\"User name\"}";
            var extended= "User name";
            //Act
            var user = userRepository.GetDeSerializeUser(userJson);
            var actual = user.Name;

            //Assert
            Assert.AreEqual(extended, actual);
        }
    }
}
