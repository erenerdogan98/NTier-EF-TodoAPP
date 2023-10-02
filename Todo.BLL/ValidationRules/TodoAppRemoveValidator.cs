using FluentValidation;
using Microsoft.EntityFrameworkCore;
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
    public class TodoAppRemoveValidator : AbstractValidator<TodoLibrary>
    {
        private readonly Context dBcontext; // buraya tanımlayıp , yapıcı metotta örnekliyeceğiz
        private readonly ITodoService _todoService;
        public TodoAppRemoveValidator(Context context, ITodoService todoService)
        {
            dBcontext = context;
            _todoService = todoService;
            RuleFor(x => x.Title).Must(TitleUnique).WithMessage("Please enter the correct title name of the register you want to delete.");
        }
        private bool TitleUnique(string title)
        {
            bool titleunique = dBcontext.Todos.Any(x => x.Title == title);
            return titleunique;
        }
    }
}
