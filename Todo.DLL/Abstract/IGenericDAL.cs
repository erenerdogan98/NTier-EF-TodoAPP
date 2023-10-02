using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.DLL.Database;

namespace Todo.DLL.Abstract
{
    public interface IGenericDAL<T> where T : class // T tipinde bir interface sınıfı oluşturup , diğer interface sınıflarımızda kullanıcaz
    {
        void Insert(T t);
        void Delete(T t) ; 
        void Update(T t); 
        List<T> GetAll() ; 
        T GetByID(int id); 
    }
}
