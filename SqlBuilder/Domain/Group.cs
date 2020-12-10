using System.Collections.Generic;

namespace SqlBuilder.Domain
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Roles { get; set; } = new List<string>();
        public List<string> Permissions { get; set; } = new List<string>();

        public List<User> Users { get; set; } = new List<User>();

        public new string ToString()
        {
            return $"{Id}: '{Name}' as {string.Join(", ", Roles)} with {string.Join(", ", Permissions)}";
        }
    }
}