using System.Collections.Generic;
using Builder.Contract;

namespace Builder.Domain
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