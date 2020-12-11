using System.Collections.Generic;
using Builder.Domain;
using NUnit.Framework;

namespace Tests
{
    public class GroupBuilderTests
    {
        private GroupBuilder _builder;
        
        [SetUp]
        public void Setup()
        {
            _builder = new GroupBuilder();
        }

        [Test]
        public void CreateAndGetGroup()
        {
            _builder.Create();

            Assert.NotNull(_builder.GetGroup());
        }

        [Test]
        public void AddRoles()
        {
            _builder.Create();
            
            var roles = new List<string> {"Default"};
            _builder.AddRoles(roles);
            
            Assert.AreEqual(roles, _builder.GetGroup().Roles);
        }

        [Test]
        public void AddPermissions()
        {
            _builder.Create();
            
            var permissions = new List<string> {"UserView"};
            _builder.AddPermissions(permissions);
            
            Assert.AreEqual(permissions, _builder.GetGroup().Permissions);
        }

        [Test]
        public void TestToString()
        {
            _builder.Create();
            
            var roles = new List<string> {"Default"};
            _builder.AddRoles(roles);
            
            var permissions = new List<string> {"UserView"};
            _builder.AddPermissions(permissions);

            var group = _builder.GetGroup();
            group.Id = 1;
            group.Name = "Test";
            
            Assert.AreEqual("1: 'Test' as Default with UserView", group.ToString());
        }
    }
}