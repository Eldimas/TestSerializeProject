using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSerializeProject.Models;
using TestSerializeProject.Repository;

namespace TestSerializeProject.Test
{
    [TestClass]
    public class User2Test
    {
        [TestMethod]
        public void GetUser2Serialize()
        {
            //Arrange
            var user = new User2();
            user.Id = 1;
            user.Name = "User2";
            user.PhotoAlbum = new List<Photo>()
            {
                new Photo() {Id = 1, Name = "Photo 1"},
                new Photo() {Id = 2, Name = "Photo 2"}
            };
            var userRepository = new User2Repository();
            var extended = "{\"id\":1,\"name\":\"User2\",\"photo_album\":[{\"id\":1,\"name\":\"Photo 1\"},{\"id\":2,\"name\":\"Photo 2\"}]}";
            //Act
            var actual = userRepository.GetUser2Serialize(user);
            //Assert
            Assert.AreEqual(extended, actual);
        }

        [TestMethod]
        public void GetUserDeserialize()
        {
            //Arrange
            var userRepository=new User2Repository();
            var user2Json= "{\"id\":1,\"name\":\"User2\",\"photo_album\":[{\"id\":1,\"name\":\"Photo 1\"},{\"id\":2,\"name\":\"Photo 2\"}]}";
            var extended = "User2";

            //Act
            User2 user = userRepository.GetUser2Deserialize(user2Json);
            var actual = user.Name;
            //Assert
            Assert.AreEqual(extended, actual);
        }

    }


}
