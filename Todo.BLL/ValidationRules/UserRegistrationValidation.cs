using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Todo.BLL.Abstract;
using Todo.DLL.Database;
using Todo.Entities;

namespace Todo.BLL.ValidationRules
{
    public class UserRegistrationValidation : AbstractValidator<User>
    {
        private readonly Context dBcontext; // buraya tanımlayıp , yapıcı metotta örnekliyeceğiz
        private readonly IUserService _userService;
        public UserRegistrationValidation(Context context, IUserService userService)
        {
            dBcontext = context;
            _userService = userService;

            RuleFor(x => x.Email).Must(BeUniqueEmail).WithMessage("There is already registration with this email!");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.Password).MinimumLength(8).WithMessage("Şifre en az 8 karakter olmalıdır");
            RuleFor(x => x.Password).Matches("[A-Za-z]").WithMessage("Şifre en az bir harf içermelidir");
            RuleFor(x => x.Password).Matches("[0-9]").WithMessage("Şifre en az bir rakam içermelidir");


            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("PhoneNumber boş geçilemez");
            RuleFor(x => x.PhoneNumber).Matches("^[0-9]+$").WithMessage("PhoneNumber sadece rakam içermelidir");

           
            RuleFor(x => x.UserRole).NotEmpty().WithMessage("User Role can not be empty , please choose one");
        }
        private bool BeUniqueEmail(string email)
        {
            bool isEmailUnique = !dBcontext.Users.Any(u => u.Email == email);
            return isEmailUnique;
        }
      
        //private bool NotBeAdminWithoutApproval(string userRole)
        //{
        //    bool notadmin = !dBcontext.Users.Any(u => u.UserRole == "Admin");
        //    return notadmin;
        //}

    }

}
