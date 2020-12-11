using System.Collections.Generic;
using Builder.Domain;
using NUnit.Framework;

namespace Tests
{
    public class UserBuilderTests
    {
        private UserBuilder _builder;
        
        [SetUp]
        public void Setup()
        {
            _builder = new UserBuilder();
        }

        [Test]
        public void CreateAndGetUser()
        {
            _builder.Create();
            
            Assert.NotNull(_builder.GetUser());
        }

        [Test]
        public void AddRoles()
        {
            _builder.Create();
            
            var roles = new List<string> {"Default"};
            _builder.AddRoles(roles);
            
            Assert.AreEqual(roles, _builder.GetUser().Roles);
        }

        [Test]
        public void AddPermissions()
        {
            _builder.Create();
            
            var permissions = new List<string> {"UserView"};
            _builder.AddPermissions(permissions);
            
            Assert.AreEqual(permissions, _builder.GetUser().Permissions);
        }

        [Test]
        public void TestToString()
        {
            _builder.Create();
            
            var roles = new List<string> {"Default"};
            _builder.AddRoles(roles);
            
            var permissions = new List<string> {"UserView"};
            _builder.AddPermissions(permissions);

            var user = _builder.GetUser();
            user.Id = 1;
            user.Name = "Test";
            
            Assert.AreEqual("1: 'Test' as Default with UserView", user.ToString());
        }
    }
}