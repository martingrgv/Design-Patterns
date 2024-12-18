using Repository.Models;

namespace Repository.Repositories
{
    public class UserRepository
    {
        public IEnumerable<User> Users()
        {
            return new List<User>();
        }

        public void AddUser(User user)
        {
            Console.WriteLine("Adding new user.");
        }

        public User GetUserById(int id)
        {
            Console.WriteLine("Returing user with id: " + id);
            return new User();
        }

        public void UpdateUser(User user)
        {
            Console.WriteLine("Updating user.");
        }

        public void DeleteUser(User user)
        {
            Console.WriteLine("Adding new product.");
        }

        public void DeleteUserById(int id)
        {
            Console.WriteLine("Deleting user with id: " + id);
        }
    }
}
    }
}
