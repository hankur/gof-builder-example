using System.Collections.Generic;
using Builder.Domain;
using NUnit.Framework;

namespace Tests
{
    public class UserTests
    {
        private User _user;
        
        [SetUp]
        public void Setup()
        {
            _user = new User
            {
                Id = 1,
                Name = "Test",
                Roles = new List<string> {"Default"},
                Permissions = new List<string> {"UserView"}
            };
        }

        [Test]
        public void Init()
        {
            Assert.AreEqual(1, _user.Id);
            Assert.AreEqual("Test", _user.Name);
            Assert.AreEqual(new List<string> {"Default"}, _user.Roles);
            Assert.AreEqual(new List<string> {"UserView"}, _user.Permissions);
        }

        [Test]
        public void TestToString()
        {
            Assert.AreEqual("1: 'Test' as Default with UserView", _user.ToString());
        }
    }
}