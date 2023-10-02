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
using Todo.Entities;

namespace Todo.UI
{
    public partial class TodoApp_NewRegister : Form
    {
        private readonly TodoAppRegisterValidator _validation;
        private readonly ITodoService _todoservice;
        private readonly TodoAppUpdateValidator _upvalidation;
        private readonly TodoAppRemoveValidator _removevalidation;
        private readonly int _loggedInUserId;
        public TodoApp_NewRegister(TodoAppRegisterValidator validations, ITodoService todoService, TodoAppUpdateValidator upvalidation, TodoAppRemoveValidator removevalidation, int UserID)
        {
            InitializeComponent();
            _validation = validations;
            _todoservice = todoService;
            _upvalidation = upvalidation;
            _removevalidation = removevalidation;
            _loggedInUserId = UserID;
        }

        private void btn_newreg_Click(object sender, EventArgs e)
        {

            if (btn_newreg.Text == "New Register")
            {
                #region parameters
                string title = txt_title.Text;
                string shortdesc = txt_shortdescription.Text;
                string description = txt_description.Text;
                int importance = int.Parse(txt_importance.Text);
                string status = cmb_status.Text;
                DateTime creationdate = DateTime.Now;
                #endregion
                var NewRegistration = new TodoLibrary
                {
                    Title = title,
                    BriefDescription = shortdesc,
                    Description = description,
                    Importance = importance,
                    StatusDescription = status,
                    Creationdate = creationdate,
                    UserID = _loggedInUserId
                };


                ValidationResult validationResult = _validation.Validate(NewRegistration);
                if (validationResult.IsValid)
                {
                    _todoservice.Add(NewRegistration);
                    DialogResult dialogResult = MessageBox.Show("Successfully registered.Do you want to any other register?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (var item in panel2.Controls)
                        {
                            if (item is TextBox)
                            {
                                ((TextBox)item).Text = string.Empty;
                            }
                            else if (item is ComboBox)
                            {
                                ((ComboBox)item).Text = string.Empty;
                            }
                        }
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    StringBuilder ErrorMessage = new StringBuilder();
                    foreach (var error in validationResult.Errors)
                    {
                        ErrorMessage.AppendLine($"{error.PropertyName}: {error.ErrorMessage}");
                    }
                    MessageBox.Show(ErrorMessage.ToString());
                }
            }
            else if (btn_newreg.Text == "Update")
            {
                #region 
                string title = txt_title.Text;
                string shortdesc = txt_shortdescription.Text;
                string description = txt_description.Text;
                int importance = int.Parse(txt_importance.Text);
                string status = cmb_status.Text;
                DateTime creationdate = DateTime.Now;
                #endregion
                var UpdateRegistration = _todoservice.GeybyTitle(title);
                if (UpdateRegistration != null)
                {
                    UpdateRegistration.BriefDescription = shortdesc;
                    UpdateRegistration.Description = description;
                    UpdateRegistration.Importance = importance;
                    UpdateRegistration.StatusDescription = status;
                    UpdateRegistration.Creationdate = creationdate;

                    ValidationResult validationResult = _upvalidation.Validate(UpdateRegistration);
                    if (validationResult.IsValid)
                    {
                        _todoservice.Update(UpdateRegistration);
                        MessageBox.Show("Güncelleme işlemi başarılı", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        StringBuilder ErrorMessage = new StringBuilder();
                        foreach (var error in validationResult.Errors)
                        {
                            ErrorMessage.AppendLine($"{error.PropertyName}: {error.ErrorMessage}");
                        }
                        MessageBox.Show(ErrorMessage.ToString());
                    }
                }
            }
            else if (btn_newreg.Text == "Remove")
            {
                string title = txt_title.Text;
                var RemoveRegistration = _todoservice.GeybyTitle(title);
                if (RemoveRegistration != null)
                {
                    ValidationResult validationResult = _removevalidation.Validate(RemoveRegistration);
                    if (validationResult.IsValid)
                    {
                        _todoservice.Delete(RemoveRegistration);
                        MessageBox.Show("Silme işleminiz başarılı", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        StringBuilder ErrorMessage = new StringBuilder();
                        foreach (var error in validationResult.Errors)
                        {
                            ErrorMessage.AppendLine($"{error.PropertyName}: {error.ErrorMessage}");
                        }
                        MessageBox.Show(ErrorMessage.ToString());
                    }
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_newreg_MouseEnter(object sender, EventArgs e)
        {
            btn_newreg.BackColor = Color.Transparent;
        }

        private void btn_newreg_MouseMove(object sender, MouseEventArgs e)
        {
            btn_newreg.BackColor = Color.Transparent;
        }

        private void TodoApp_NewRegister_Load(object sender, EventArgs e)
        {
            if (btn_newreg.Text == "Update")
            {
                //txt_title.Text = "Güncellemek istediğiniz başlık ismini giriniz";
                MessageBox.Show("Lütfen güncellemek istediğiniz başlık adını giriniz", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_title_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;
        }

        private void txt_title_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }
    }
}
