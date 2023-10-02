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
    public class TodoService : ITodoService
    {
        EFTodoRepository _eftodorepository;
        public TodoService()
        {
            _eftodorepository = new EFTodoRepository();
        }
        public void Add(TodoLibrary t)
        {
            _eftodorepository.Insert(t);
        }

        public void Delete(TodoLibrary t)
        {
            _eftodorepository.Delete(t);
        }

        public List<TodoLibrary> GetAll()
        {
            return _eftodorepository.GetAll();
        }

        public TodoLibrary GetByID(int id)
        {
            return _eftodorepository.GetByID(id);
        }

        public TodoLibrary GeybyTitle(string title)
        {
            return _eftodorepository.GetbyTitle(title);
        }

        public void Update(TodoLibrary t)
        {
            _eftodorepository.Update(t);
        }
    }
}
