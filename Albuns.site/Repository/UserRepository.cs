using Albuns.site.Models;
using System.Collections.Generic;
using System.Linq;

namespace Albuns.site.Repository
{
    public class UserRepository
    {
        public List<User> getUsers()
        {
            var url = @"https://jsonplaceholder.typicode.com/users";
            var readJason = new ReadJason();
            return readJason.readUrl<User>(url).ToList();
        }
    }
}