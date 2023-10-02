using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.BLL.Abstract;
using Todo.DLL.EntityFramework;
using Todo.Entities;

namespace Todo.BLL.Services
{
    public class UserService : IUserService
    {
        EFUserRepository eFUserRepository; // class seviyesinde çağırım , yapıcı metotumuzda new ile örnekleyeceğiz

        public UserService()
        {
            eFUserRepository = new EFUserRepository();
        }

        public void Add(User user)
        {
            eFUserRepository.Insert(user);
        }

        public void Delete(User user)
        {
            eFUserRepository.Delete(user);
        }

        public List<User> GetAll()
        {
            return eFUserRepository.GetAll();
        }

        public User GetByUsername(string username)
        {
            return eFUserRepository.GetByUsername(username);
        }

        public User GetUserByid(int id)
        {
            return eFUserRepository.GetByID(id);
        }

        public User Login(string username, string password)
        {
            return eFUserRepository.Login(username, password);
        }

        public void Update(User user)
        {
            eFUserRepository.Update(user);
        }
    }
}
