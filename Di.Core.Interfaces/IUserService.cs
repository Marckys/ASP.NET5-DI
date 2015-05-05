using Di.Core.Dto;

namespace Di.Core.Interfaces
{
    public interface IUserService
    {
        User[] GetAll();
        User Get();
        string GetName();
    }
}
