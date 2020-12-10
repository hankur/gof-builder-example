using System.Collections.Generic;

namespace SqlBuilder.Domain
{
    public class Manager
    {
        public void CreateDefault(IBuilder builder)
        {
            builder.Create();
            builder.AddRoles(new List<string>{"Default"});
            builder.AddPermissions(new List<string>{"UserView"});
        }
        
        public void CreateAdmin(IBuilder builder)
        {
            builder.Create();
            builder.AddRoles(new List<string>{"Admin"});
            builder.AddPermissions(new List<string>{"UserView", "AdminView"});
        }
    }
}