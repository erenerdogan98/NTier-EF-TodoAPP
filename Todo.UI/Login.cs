using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.BLL.Abstract;
using Todo.BLL.Services;
using Todo.BLL.ValidationRules;
using Todo.Entities;

namespace Todo.UI
{
    public partial class Login : Form
    {
        private readonly UserRegistrationValidation _userRegistrationValidation;
        private readonly IUserService _userService;
        private readonly UserLoginValidation _userLoginValidation;
        private readonly TodoAppRegisterValidator _todoappregistervalidation;
        private readonly ITodoService _todoservice;
        private readonly TodoAppUpdateValidator _todoappupdatevalidation;
        private readonly TodoAppRemoveValidator _todoappremovevalidation;
        private string _username; // kayıt ekranında mesaj olarak göstericem

        public Login(UserRegistrationValidation validationRules, IUserService userService, UserLoginValidation userLoginValidation, TodoAppRegisterValidator todoappregistervalidation, ITodoService todoservice, TodoAppUpdateValidator todoappupdatevalidation, TodoAppRemoveValidator todoappremovevalidation)
        {
            InitializeComponent();
            _userRegistrationValidation = validationRules;
            _userService = userService;
            _userLoginValidation = userLoginValidation;
            _todoappregistervalidation = todoappregistervalidation;
            _todoservice = todoservice;
            _todoappupdatevalidation = todoappupdatevalidation;
            _todoappremovevalidation = todoappremovevalidation;
            _username = string.Empty;
            CheckAdmin();
        }
        private void CheckAdmin()
        {
            if (!_userService.GetAll().Any(x => x.IsAdmin))
            {
                var AdminUser = new User
                {
                    UserName = "Admin",
                    Password = "123admin456",
                    Email = "eren.erdogannn@hotmail.com",
                    PhoneNumber = "123456789",
                    IsAdmin = true,
                    UserRole = "Admin"
                };
                _userService.Add(AdminUser);
            }
        }

        private void btn_register_Click(object sender, EventArgs e) // register
        {
            Register register = new Register(_userRegistrationValidation, _userService);
            register.FormClosed += Register_FormClosed;
            register.Show();
        }

        private void Register_FormClosed(object? sender, FormClosedEventArgs e)
        {
            txt_username.Text = string.Empty;
            txt_password.Text = string.Empty;
            this.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            _username = username;
            var UserLogin = new User { UserName = username, Password = password };
            ValidationResult validationResult = _userLoginValidation.Validate(UserLogin);
            if (validationResult.IsValid)
            {
                var loggedInUser = _userService.GetByUsername(username); // bu metodun tanımlanması gerekebilir
                int loggedInUserId = loggedInUser.UserID;
                if (loggedInUser.IsAdmin)
                {
                    MessageBox.Show("Admin login is successful.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    AdminControl adminControl = new AdminControl(_userService,_todoservice,loggedInUserId);
                    adminControl.FormClosed += AdminControl_FormClosed;
                    adminControl.Show();
                }
                else
                {
                    MessageBox.Show("Successful Login", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TodoApp todoApp = new TodoApp(_todoappregistervalidation, _todoservice, _todoappupdatevalidation, _todoappremovevalidation, _username, loggedInUserId,_userService);
                    todoApp.FormClosed += TodoApp_FormClosed;
                    todoApp.Show();
                }
                this.Hide();
            }
            else
            {
                StringBuilder ErrorMessage = new StringBuilder();
                foreach (var error in validationResult.Errors)
                {
                    ErrorMessage.AppendLine(error.ErrorMessage);
                }
                MessageBox.Show(ErrorMessage.ToString());
            }
        }

        private void AdminControl_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
            txt_username.Text = string.Empty;
            txt_password.Text = string.Empty;
        }

        private void TodoApp_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
            txt_username.Text = string.Empty;
            txt_password.Text = string.Empty;
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_TabIndexChanged(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            B.BackColor = Color.Gold;
        }

        private void btn_login_TabStopChanged(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            B.BackColor = Color.Gold;
        }
    }
}