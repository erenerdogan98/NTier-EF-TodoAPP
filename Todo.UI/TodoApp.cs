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
    public partial class TodoApp : Form
    {
        TodoAppRegisterValidator _registervalidator;
        ITodoService _todoservice;
        TodoAppUpdateValidator _updatevalidator;
        TodoAppRemoveValidator _removevalidator;
        User user;
        private readonly int _loggedInUserId;
        private readonly IUserService _userService;



        public TodoApp(TodoAppRegisterValidator registervalidator, ITodoService todoService, TodoAppUpdateValidator updatevalidator, TodoAppRemoveValidator revalidation, string username, int UserID, IUserService userService)
        {
            InitializeComponent();
            _registervalidator = registervalidator;
            _todoservice = todoService;
            _updatevalidator = updatevalidator;
            _removevalidator = revalidation;
            _loggedInUserId = UserID;
            user = new User { UserName = username };
            MessageBox.Show($"Welcome {username} ");
            _userService = userService;
        }

        private void btn_operations_Click(object sender, EventArgs e)
        {
            #region , I took buttons into to groupbox
            //if (btn_close.Visible == false && btn_newreg.Visible == false && btn_showlist.Visible == false)
            //{
            //    btn_close.Visible = true; btn_newreg.Visible = true; btn_showlist.Visible = true;
            //}
            //else if (btn_close.Visible == true && btn_newreg.Visible == true && btn_showlist.Visible == true)
            //{
            //    btn_close.Visible = false; btn_newreg.Visible = false; btn_showlist.Visible = false;
            //}
            #endregion
            if (grp_buttonstodo.Visible == false)
            {
                grp_buttonstodo.Visible = true;
            }
            else if (grp_buttonstodo.Visible == true) { grp_buttonstodo.Visible = false; }
        }

        private void TodoApp_Load(object sender, EventArgs e)
        {


            grp_buttonstodo.Visible = false;
            tmr.Interval = 5000; // every 5 seconds
            tmr.Tick += Tmr_Tick;
            tmr.Start();
        }

        private void Tmr_Tick(object? sender, EventArgs e)
        {
            lbl_timer.Text = DateTime.Now.ToString("dd.MM.yyyy HH.dd");
        }

        private void btn_newreg_Click(object sender, EventArgs e)
        {
            TodoApp_NewRegister todoApp_NewRegister = new TodoApp_NewRegister(_registervalidator, _todoservice, _updatevalidator, _removevalidator, _loggedInUserId);
            todoApp_NewRegister.FormClosed += TodoApp_NewRegister_FormClosed; // Yeni form kapatıldığında bir olay tetiklenecek
            todoApp_NewRegister.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            todoApp_NewRegister.Show();

        }
        private void TodoApp_NewRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Yeni form kapatıldığında ana formu tekrar göster
        }

        private void btn_showlist_Click(object sender, EventArgs e)
        {
            TodoApp_ShowList todoApp_ShowList = new TodoApp_ShowList(_todoservice, _loggedInUserId, _userService);
            todoApp_ShowList.FormClosed += TodoApp_ShowList_FormClosed;
            this.Hide();
            todoApp_ShowList.Show();
        }

        private void TodoApp_ShowList_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            TodoApp_NewRegister todoApp_NewRegister = new TodoApp_NewRegister(_registervalidator, _todoservice, _updatevalidator, _removevalidator, _loggedInUserId);
            todoApp_NewRegister.FormClosed += TodoApp_NewRegister_FormClosed; // Yeni form kapatıldığında bir olay tetiklenecek
            todoApp_NewRegister.StartPosition = FormStartPosition.CenterScreen;
            Panel pnl = (Panel)todoApp_NewRegister.Controls["panel2"];
            Button btn = (Button)pnl.Controls["btn_newreg"];
            btn.Text = "Update";

            this.Hide();
            todoApp_NewRegister.Show();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            TodoApp_NewRegister todoApp_NewRegister = new TodoApp_NewRegister(_registervalidator, _todoservice, _updatevalidator, _removevalidator, _loggedInUserId);
            todoApp_NewRegister.FormClosed += TodoApp_NewRegister_FormClosed; // Yeni form kapatıldığında bir olay tetiklenecek
            todoApp_NewRegister.StartPosition = FormStartPosition.CenterScreen;
            Panel pnl = (Panel)todoApp_NewRegister.Controls["panel2"];
            Button btn = (Button)pnl.Controls["btn_newreg"];
            btn.Text = "Remove";

            this.Hide();
            todoApp_NewRegister.Show();
        }
    }
}
