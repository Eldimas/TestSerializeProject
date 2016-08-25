using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSerializeProject.Models;
using TestSerializeProject.Repository;

namespace TestSerializeProject.Test
{
    [TestClass]
    public class User1Test
    {
        [TestMethod]
        public void GetUser1Serialize()
        {
            //Arrange
            var user1Repository = new User1Repository();

            var user1 = new User1();
            user1.Id = 1;
            user1.Name = "User1";
            user1.GenderEnum =User1.Gender.Male;

            var extended = "{\"id\":1,\"name\":\"User1\",\"gender\":\"Male\"}";
            //Act
            var actual = user1Repository.GetSerialize(user1);

            //Assert
            Assert.AreEqual(extended, actual);
        }

        [TestMethod]
        public void GetDeserialize()
        {
            //Arrange
            var user1Repository=new User1Repository();
            //var userJson= "{\"Id\":1,\"Name\":\"User1\",\"GenderEnum\":\"Male\"}";
            var userJson = "{\"id\":1,\"name\":\"User1\",\"gender\":\"Male\"}";
            var extended = "User1";

            

            //Act
            User1 user = user1Repository.GetDeserialize(userJson);
            var actual = user.Name;


            //Assert
            Assert.AreEqual(extended, actual);

        }
    }
}
