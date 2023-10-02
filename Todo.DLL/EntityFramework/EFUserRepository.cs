using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.DLL.Abstract;
using Todo.DLL.Database;
using Todo.DLL.Repository;
using Todo.Entities;

namespace Todo.DLL.EntityFramework
{
    public class EFUserRepository : GenericRepository<User>, IUserDAL // ileride başka bir veritabanı işlemi yaparsak , kolaylık sağlaması için
    {
        public User Login(string username, string password)
        {
            using var c = new Context();
            return c.Users.FirstOrDefault(x => x.UserName == username && x.Password == password);
        }
        public User GetByUsername(string username)
        {
            using var c = new Context();
            return c.Users.FirstOrDefault(x => x.UserName == username);
        }
    }
}
