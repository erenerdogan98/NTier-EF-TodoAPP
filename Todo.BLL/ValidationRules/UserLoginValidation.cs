using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.BLL.Abstract;
using Todo.DLL.Database;
using FluentValidation;
using Todo.Entities;
using System.Security.Cryptography.X509Certificates;

namespace Todo.BLL.ValidationRules
{
    public class UserLoginValidation : AbstractValidator<User>
    {
        private readonly Context dBcontext; // buraya tanımlayıp , yapıcı metotta örnekliyeceğiz
        private readonly IUserService _userService;
        public UserLoginValidation(Context context, IUserService userService)
        {
            dBcontext = context;
            _userService = userService;

            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x).Must(Control).WithMessage("Kullanıcı adı veya şifre hatalı");
        }
        public bool Control(User user)
        {
            bool control = dBcontext.Users.Any(x => (x.UserName == user.UserName && x.Password == user.Password));
            return control;
        }

    }
}
