using System.Security.Principal;

namespace ApplicationCore.Interfaces
{
    interface IIdentityParser<T>
    {
        T Parse(IPrincipal principal);
    }
}
