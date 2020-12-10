using System.Collections.Generic;

namespace SqlBuilder
{
    public interface IBuilder
    {
        void Create();
        void AddRoles(List<string> roles);
        void AddPermissions(List<string> permissions);
    }
}