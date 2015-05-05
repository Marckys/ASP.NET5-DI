using Di.Core.Dto;
using Di.Core.Interfaces;

namespace Di.Core.Services
{
    public class UserService : IUserService
    {

        private readonly User[] Users;

        public UserService()
        {
            Users = new User[] {
                new User { Name = "Marc", SecondName = "Rubiño", City = "Barcelona" },
                new User { Name = "Paula", SecondName = "Rubiño", City = "Cambrils" },
                new User { Name = "Montse", SecondName = "Luna", City = "Granollers" },
                new User { Name = "Marquitos", SecondName = "Rubiño", City = "Granollers" }
            };
        }


        public User[] GetAll()
        {
            return Users;
        }

        public User Get()
        {
            return Users[0];
        }

        public string GetName()
        {
            return Get().Name;
        }
    }
}
