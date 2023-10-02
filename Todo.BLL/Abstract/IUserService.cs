using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Entities;

namespace Todo.BLL.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        List<User> GetAll();
        User GetUserByid(int id);
        User Login (string username, string password);
        User GetByUsername(string username);
    }
}
