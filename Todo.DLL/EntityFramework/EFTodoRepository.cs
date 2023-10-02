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
    public class EFTodoRepository : GenericRepository<TodoLibrary>, ITodoLibraryDAL
    {
        public TodoLibrary GetbyTitle(string title)
        {
            using var c = new Context();
            return c.Todos.FirstOrDefault(x => x.Title == title);
        }
        //using var c = new Context();: Bu satır, Context sınıfının bir örneğini oluşturur. using anahtar kelimesi, Context nesnesinin işi bittiğinde bellekten düzgün bir şekilde temizlenmesini sağlar.Bu, Entity Framework Core'un DbContext sınıfının yaşam döngüsünün yönetilmesi için yaygın bir yaklaşımdır.
    }
}
