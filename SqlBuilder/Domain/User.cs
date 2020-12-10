using System.Collections.Generic;

namespace SqlBuilder.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Roles { get; set; } = new List<string>();
        public List<string> Permissions { get; set; } = new List<string>();

        public new string ToString()
        {
            return $"{Id}: '{Name}' as {string.Join(", ", Roles)} with {string.Join(", ", Permissions)}";
        }
    }
}