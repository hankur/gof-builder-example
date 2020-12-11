using System;
using System.Collections.Generic;
using Builder.Domain;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
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
            
            // Demonstrate result
            Console.WriteLine($"Default user: {defaultUser.ToString()}");
            Console.WriteLine($"Admin user: {adminUser.ToString()}");
            Console.WriteLine($"Default group: {defaultGroup.ToString()}");
            Console.WriteLine($"Admin group: {adminGroup.ToString()}");
        }
    }
}