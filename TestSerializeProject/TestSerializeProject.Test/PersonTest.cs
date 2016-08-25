using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSerializeProject.Models;
using TestSerializeProject.Repository;

namespace TestSerializeProject.Test
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void GetSerializePerson()
        {
            //Arrange
            var personRepository = new PersonRepository();
            var person=new Person();
            person.Id = 1;
            person.Name = "Person name";
            person.GenderEnum = Person.Gender.Male;

            var extended = "{\"Id\":1,\"Name\":\"Person name\",\"GenderEnum\":\"Male\"}";
            //Act
            var actual = personRepository.GetPersonSerialize(person);

            //Assert
            Assert.AreEqual(extended, actual);
        }

        [TestMethod]
        public void GetDeserializePerson()
        {
            //Arrange
            var personRepository = new PersonRepository();
            var personJson = "{\"Id\":1,\"Name\":\"Person name\",\"GenderEnum\":\"Male\"}";
            var extended = "Person name";

            //Act
            var person = personRepository.GetDeserializePerson(personJson);
            var actual = person.Name;

            //Assert
            Assert.AreEqual(extended, actual);
        }

    }
}
