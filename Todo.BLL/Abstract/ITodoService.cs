using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Entities;

namespace Todo.BLL.Abstract
{
    public interface ITodoService
    {
        void Add(TodoLibrary t);
        void Update(TodoLibrary t);
        void Delete(TodoLibrary t);
        List<TodoLibrary> GetAll();
        TodoLibrary GetByID(int id);
        TodoLibrary GeybyTitle(string title);
    }
}
