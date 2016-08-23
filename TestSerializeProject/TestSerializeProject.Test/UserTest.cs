using System;
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

            var extended = "{\"Id\":1,\"Name\":\"User name\"}";

            //Act
            var actual = userRepository.GetSerializeUser(user);
            //Assert
            Assert.AreEqual(extended, actual);
        }
    }
}
