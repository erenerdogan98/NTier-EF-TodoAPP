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

namespace Todo.UI
{
    public partial class AdminControl : Form
    {
        private readonly IUserService _userService;
        private readonly ITodoService _todoservice;
        private readonly int _loggedInUserId;
        public AdminControl(IUserService userService, ITodoService todoservice, int loggedInUserId)
        {
            InitializeComponent();
            _userService = userService;
            panel1.Visible = false;
            dgv_adminrequests.Visible = false;
            this.Size = new Size(200, 285);
            btn_Accept.Visible = false;
            btn_Reject.Visible = false;
            AdminRequestsList();
            _todoservice = todoservice;
            _loggedInUserId = loggedInUserId;
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {

        }
        private void AdminRequestsList()
        {
            var adminrequest = _userService.GetAll().Where(x => x.IsAdminRequest && !x.IsAdmin).ToList();
            dgv_adminrequests.DataSource = adminrequest;
        }

        private void btn_adminrequest_Click(object sender, EventArgs e)
        {
            dgv_adminrequests.DataSource = null;
            panel1.Visible = true;
            dgv_adminrequests.Visible = true;
            AdminRequestsList();
            if (dgv_adminrequests.DataSource != null)
            {
                btn_Accept.Visible = true;
                btn_Reject.Visible = true;
            }
            this.Size = new Size(565, 324);
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            if (dgv_adminrequests.SelectedRows.Count > 0)
            {
                int selectedUserID = Convert.ToInt32(dgv_adminrequests.SelectedRows[0].Cells["UserID"].Value);
                var user = _userService.GetUserByid(selectedUserID);
                if (user != null)
                {
                    user.IsAdmin = true;
                    user.IsAdminRequest = false; // Since it has been approved, we are removing the request.
                    _userService.Update(user);
                    AdminRequestsList();
                    MessageBox.Show("The user's admin request has been approved.", "Information", MessageBoxButtons.OK);
                }
            }
        }

        private void btn_Reject_Click(object sender, EventArgs e)
        {
            if (dgv_adminrequests.SelectedRows.Count > 0)
            {
                int selectedUserID = Convert.ToInt32(dgv_adminrequests.SelectedRows[0].Cells["UserID"].Value);
                var user = _userService.GetUserByid(selectedUserID);
                if (user != null)
                {
                    user.IsAdmin = false;
                    user.IsAdminRequest = false; // Since it has been approved, we are removing the request.
                    _userService.Update(user);
                    AdminRequestsList();
                    MessageBox.Show("The user's admin request was rejected.", "Information", MessageBoxButtons.OK);
                }
            }
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

        private void button1_Click(object sender, EventArgs e) // userlist
        {

            dgv_adminrequests.DataSource = null;
            panel1.Visible = true;
            dgv_adminrequests.Visible = true;
            UserList();

            this.Size = new Size(565, 324);
        }
        private void UserList()
        {
            var userlist = _userService.GetAll().Where(x => !x.IsAdminRequest).ToList();
            dgv_adminrequests.DataSource = userlist;
        }

        private void UserList_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
