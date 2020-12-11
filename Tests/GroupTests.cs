using System.Collections.Generic;
using Builder.Domain;
using NUnit.Framework;

namespace Tests
{
    public class GroupTests
    {
        private Group _group;
        
        [SetUp]
        public void Setup()
        {
            _group = new Group
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
            Assert.AreEqual(1, _group.Id);
            Assert.AreEqual("Test", _group.Name);
            Assert.AreEqual(new List<string> {"Default"}, _group.Roles);
            Assert.AreEqual(new List<string> {"UserView"}, _group.Permissions);
        }

        [Test]
        public void TestToString()
        {
            Assert.AreEqual("1: 'Test' as Default with UserView", _group.ToString());
        }
    }
}