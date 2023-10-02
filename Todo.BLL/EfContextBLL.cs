using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Todo.BLL.Abstract;
using Todo.BLL.Services;
using Todo.BLL.ValidationRules;
using Todo.DLL.Database;
using Todo.DLL.EntityFramework;

namespace Todo.BLL
{
    public static class EfContextBLL
    {
        public static void AddScopeBLL(this IServiceCollection services)
        {
            services.AddScopeDAL();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<UserRegistrationValidation>();
            services.AddScoped<UserLoginValidation>();

            services.AddScoped<ITodoService, TodoService>();
            services.AddScoped<TodoAppRegisterValidator>();
            services.AddScoped<TodoAppUpdateValidator>();
            services.AddScoped<TodoAppRemoveValidator>();

            services.AddDbContext<Context>();
        }
    }
}
