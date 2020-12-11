using System.Collections.Generic;
using Builder.Contract;

namespace Builder.Domain
{
    public class GroupBuilder : IBuilder
    {
        private Group _group;
        
        public void Create()
        {
            _group = new Group();
        }

        public void AddRoles(List<string> roles)
        {
            _group.Roles.AddRange(roles);
        }

        public void AddPermissions(List<string> permissions)
        {
            _group.Permissions.AddRange(permissions);
        }

        public Group GetGroup()
        {
            return _group;
        }
    }
}