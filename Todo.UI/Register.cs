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
using Todo.BLL.ValidationRules;
using FluentValidation;
using Todo.Entities;
using Todo.BLL.Helper;

namespace Todo.UI
{
    public partial class Register : Form
    {
        private readonly UserRegistrationValidation _userRegistrationValidation;
        private readonly IUserService _userService;
        public Register(UserRegistrationValidation validationRules, IUserService userService)
        {
            InitializeComponent();
            _userRegistrationValidation = validationRules;
            _userService = userService;
        }
        #region Admin Onayı

        public void RequestAdminRole(int userId)
        {
            var user = _userService.GetUserByid(userId);
            if (user != null)
            {
                user.IsAdminRequest = true;
                _userService.Update(user);
            }
        }

        public void ApproveAdminRole(int userId)
        {
            var user = _userService.GetUserByid(userId);
            if (user != null && user.IsAdminRequest)
            {
                user.IsAdmin = true;
                _userService.Update(user);
            }
        }

        #endregion
        private void btn_reg_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string email = txt_email.Text;
            string phone = txt_phone.Text;
            string userrole = cmb_userrole.Text;
            var UserRegistration = new User
            {
                UserName = username,
                Password = password,
                Email = email,
                PhoneNumber = phone,
                UserRole = userrole
            };

            ValidationResult validationResult = _userRegistrationValidation.Validate(UserRegistration);
            if (validationResult.IsValid)
            {
                if (userrole.Equals("Admin"))
                {
                    UserRegistration.IsAdminRequest = true;
                    _userService.Add(UserRegistration);
                    MessageBox.Show("You are waiting for admin approval.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else if (userrole.Equals("User"))
                {
                    _userService.Add(UserRegistration);
                    MessageBox.Show($"{username} kaydınız başarılı bir şekilde oluşturulmuştur");

                    string content = string.Empty;
                    string topic = "Succes Register";
                    content += "<div>";
                    content += "<p>Hello</p>";
                    content += $"<p> {username} </p>";
                    content += $"<p> Your registration was successfully created {DateTime.Now.ToShortDateString()} </p>";
                    content += $"For more information <a href = 'http://www.deneme.com' click </a></p>";
                    content += "</div>";
 
                    EmailOperations.SendEmail(username, password, email, topic, content);
                    this.Hide();
                }
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
            // ValidationResult'ı kullanarak gerekli işlemleri gerçekleştirdik.
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}