using Albums.web.Models;
using System.Collections.Generic;
using System.Linq;

namespace Albums.web.Repository
{
    public interface IUserRepository
    {
        List<User> getUsers();
    }

    public class UserRepository : IUserRepository
    {
        public List<User> getUsers()
        {
            var url = @"https://jsonplaceholder.typicode.com/users";
            var readJason = new ReadJson();
            return readJason.readUrl<User>(url).ToList();
        }
    }
}