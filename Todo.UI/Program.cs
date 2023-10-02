using Todo.BLL.Abstract;
using Todo.BLL.Services;
using Todo.BLL.ValidationRules;
using Todo.DLL.Database;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Todo.BLL;

namespace Todo.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration. 
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddScopeBLL();
            var serviceProvider = services.BuildServiceProvider();
            var MainForm = new Login(
             serviceProvider.GetRequiredService<UserRegistrationValidation>(),
             serviceProvider.GetRequiredService<IUserService>(),
             serviceProvider.GetRequiredService<UserLoginValidation>(),
             serviceProvider.GetRequiredService<TodoAppRegisterValidator>(),
             serviceProvider.GetRequiredService<ITodoService>(),
             serviceProvider.GetService<TodoAppUpdateValidator>(),
             serviceProvider.GetService<TodoAppRemoveValidator>()); // In this way, we can make the necessary service definitions more easily.

            Application.Run(MainForm);
        }
    }
}