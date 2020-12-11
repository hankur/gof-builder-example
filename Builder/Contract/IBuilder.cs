using System.Collections.Generic;

namespace Builder.Contract
{
    public interface IBuilder
    {
        void Create();
        void AddRoles(List<string> roles);
        void AddPermissions(List<string> permissions);
    }
}