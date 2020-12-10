using System.Collections.Generic;

namespace SqlBuilder.Domain
{
    public class UserBuilder : IBuilder
    {
        private User _user;
        
        public void Create()
        {
            _user = new User();
        }

        public void AddRoles(List<string> roles)
        {
            _user.Roles.AddRange(roles);
        }

        public void AddPermissions(List<string> permissions)
        {
            _user.Permissions.AddRange(permissions);
        }

        public User GetUser()
        {
            return _user;
        }
    }
}