using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.DLL.Abstract;

namespace Todo.DLL.EntityFramework
{
    public static class EFContextDAL
    {
        public static void AddScopeDAL(this IServiceCollection services)
        {
            services.AddScoped<IUserDAL, EFUserRepository>();
        }
    }
}
