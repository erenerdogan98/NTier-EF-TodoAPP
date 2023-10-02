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
    public class TodoAppUpdateValidator : AbstractValidator<TodoLibrary>
    {
        private readonly ITodoService _todoService;
        private readonly Context dbcontext;
        public TodoAppUpdateValidator(Context Dbcontext, ITodoService todoService)
        {
            _todoService = todoService;
            dbcontext = Dbcontext;

            RuleFor(x => x.Title).NotEmpty().WithMessage("The title section cannot be empty.");
            RuleFor(x => x.Title).Must(IsTitleUpper).WithMessage("The title cannot contain lowercase letters.");
            RuleFor(x => x.Title).Must(TitleUnique).WithMessage("Title couldn't found. Please write correct.");

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
        }
        private bool TitleUnique(string title)
        {
            bool titleunique = dbcontext.Todos.Any(x => x.Title == title);
            return titleunique;
        }
    }
}
