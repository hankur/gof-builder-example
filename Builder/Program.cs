using System;
using System.Collections.Generic;
using Builder.Domain;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Old way
            var oldDefaultUser = new User
            {
                Name = "Jaanus",
                Roles = new List<string>{"Default"},
                Permissions = new List<string>{"UserView"}
            };
            var oldAdminUser = new User
            {
                Name = "Peetrus",
                Roles = new List<string>{"Admin"},
                Permissions = new List<string>{"UserView", "AdminView"}
            };
            
            // Manager and Builders
            var manager = new Manager();
            var userBuilder = new UserBuilder();
            var groupBuilder = new GroupBuilder();
            
            // Default user
            manager.CreateDefault(userBuilder);
            var defaultUser = userBuilder.GetUser();
            defaultUser.Name = "Jaan";
            
            // Admin user
            manager.CreateAdmin(userBuilder);
            var adminUser = userBuilder.GetUser();
            adminUser.Name = "Peeter";
            
            // Default group
            manager.CreateDefault(groupBuilder);
            var defaultGroup = groupBuilder.GetGroup();
            defaultGroup.Name = "Tavakasutajad";
            
            // Admin group
            manager.CreateAdmin(groupBuilder);
            var adminGroup = groupBuilder.GetGroup();
            adminGroup.Name = "Admin kasutajad";
            
            // Print result
            Console.WriteLine($"Default user: {defaultUser.ToString()}");
            Console.WriteLine($"Admin user: {adminUser.ToString()}");
            Console.WriteLine($"Default group: {defaultGroup.ToString()}");
            Console.WriteLine($"Admin group: {adminGroup.ToString()}");
        }
    }
}