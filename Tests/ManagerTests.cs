using System.Collections.Generic;
using Builder.Domain;
using NUnit.Framework;

namespace Tests
{
    public class ManagerTests
    {
        private Manager _manager;
        
        [SetUp]
        public void Setup()
        {
            _manager = new Manager();
        }

        [Test]
        public void CreateDefaultUser()
        {
            var userBuilder = new UserBuilder();
            
            _manager.CreateDefault(userBuilder);

            var user = userBuilder.GetUser();
            
            Assert.AreEqual(new List<string> {"Default"}, user.Roles);
            Assert.AreEqual(new List<string> {"UserView"}, user.Permissions);
        }

        [Test]
        public void CreateDefaultGroup()
        {
            var groupBuilder = new GroupBuilder();
            
            _manager.CreateDefault(groupBuilder);

            var group = groupBuilder.GetGroup();
            
            Assert.AreEqual(new List<string> {"Default"}, group.Roles);
            Assert.AreEqual(new List<string> {"UserView"}, group.Permissions);
        }

        [Test]
        public void CreateAdminUser()
        {
            var userBuilder = new UserBuilder();
            
            _manager.CreateAdmin(userBuilder);

            var user = userBuilder.GetUser();
            
            Assert.AreEqual(new List<string> {"Admin"}, user.Roles);
            Assert.AreEqual(new List<string> {"UserView", "AdminView"}, user.Permissions);
        }

        [Test]
        public void CreateAdminGroup()
        {
            var groupBuilder = new GroupBuilder();
            
            _manager.CreateAdmin(groupBuilder);

            var group = groupBuilder.GetGroup();
            
            Assert.AreEqual(new List<string> {"Admin"}, group.Roles);
            Assert.AreEqual(new List<string> {"UserView", "AdminView"}, group.Permissions);
        }
    }
}