using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.BLL.Abstract;
using Todo.DLL.Database;
using Todo.Entities;

namespace Todo.BLL.ValidationRules
{
    public class TodoAppRegisterValidator : AbstractValidator<TodoLibrary>
    {
        private readonly ITodoService _todoService;
        private readonly Context dbcontext;
       
        public TodoAppRegisterValidator(Context Dbcontext,ITodoService todoService )
        {
            _todoService = todoService;
            dbcontext = Dbcontext;
           

            RuleFor(x => x.Title).NotEmpty().WithMessage("The title section cannot be empty.");
            RuleFor(x => x.Title).Must(IsTitleUpper).WithMessage("The title cannot contain lowercase letters.");
            RuleFor(x => x.Title).Must((todo, title) => TitleUnique(title, todo));

            RuleFor(x => x.Importance).NotEmpty().WithMessage("The importance cannot be empty.");
            RuleFor(x => x.Importance).Must(BeValidImportance).WithMessage("The importance must be a number between 1 and 5.");
            RuleFor(x => x.Importance).Must(BeNumeric).WithMessage("The importance can only contain numbers.");

            RuleFor(x => x.Description).NotEmpty().WithMessage($"The Description cannot be empty");
            RuleFor(x => x.StatusDescription).NotEmpty().WithMessage("The Status cannot be empty!");
        }
        private bool IsTitleUpper(string title)
        {
            return title == title.ToUpper();
        }
        private bool BeValidImportance(int importance)
        {
            return importance >= 1 && importance <= 5;
        }
        private bool BeNumeric(int importance)
        {
            string importanceString = importance.ToString();
            return int.TryParse(importanceString, out _);
            #region açıklama
//            Öncelikle, importance değerini bir string e dönüştürüyoruz.Bunun nedeni, int.TryParse metodunun yalnızca string türündeki değerleri analiz edebilmesidir.

//Sonra, int.TryParse metodunu kullanarak importanceString i bir int değerine dönüştürmeye çalışıyoruz. Bu metot, dönüşümün başarılı olup olmadığını kontrol eder.Eğer dönüşüm başarılıysa, yani importanceString bir sayıya dönüşebiliyorsa, true değerini döndürür. Aksi halde, yani dönüşüm başarısız olursa, false değerini döndürür.

//Bu şekilde, BeNumeric metodu, Importance özelliğinin yalnızca sayısal değerler içermesini sağlar.
            #endregion
        }
        private bool TitleUnique(string title,TodoLibrary todo) // for unique a user
        {
            return !dbcontext.Todos.Any(x => x.Title == title && x.UserID == todo.UserID);
            
        }
    }
}
