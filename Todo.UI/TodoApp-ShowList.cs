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
using Todo.Entities;

namespace Todo.UI
{
    public partial class TodoApp_ShowList : Form
    {
        private readonly ITodoService _todoservice;
        private readonly int _loggedInUserid;
        private readonly IUserService _userService;
        public TodoApp_ShowList(ITodoService todoService, int UserID,IUserService userService)
        {
            InitializeComponent();
            _todoservice = todoService;
            _loggedInUserid = UserID;
            _userService = userService;
        }

        private void TodoApp_ShowList_Load(object sender, EventArgs e)
        {
            //dtv_list.DataSource = AllList();
            //dtv_list.Columns["ID"].Visible = false;
            #region Buttons visibles , It will be easier to write in a groupbox instead of doing this one by one.
            //btn_alllist.Visible = false;
            //btn_canceled.Visible = false;
            //btn_completed.Visible = false;
            //btn_incompleted.Visible = false;
            //btn_pending.Visible = false;
            //btn_postponed.Visible = false;
            #endregion
            grp_buttons.Visible = false;
        }
        private List<TodoLibrary> AllList()
        {
            if (IsAdmin(_loggedInUserid))
            {
                return _todoservice.GetAll();
            }
            else
            {
               
                return _todoservice.GetAll().Where(x => x.UserID == _loggedInUserid).ToList();
               
            
                
            }

        }
        private bool IsAdmin(int UserID)
        {
            var user = _userService.GetUserByid(UserID);
            return user?.IsAdmin ?? false; // if user is admin it returns true , else false
        }

        private void btn_operations_Click(object sender, EventArgs e)
        {
            //if (btn_alllist.Visible == false && btn_canceled.Visible == false && btn_completed.Visible == false
            //    && btn_incompleted.Visible == false && btn_pending.Visible == false) { }
            if (grp_buttons.Visible == false)
            {
                grp_buttons.Visible = true;
            }
            else if (grp_buttons.Visible == true)
            {
                grp_buttons.Visible = false;
            }
        }

        private void btn_alllist_Click(object sender, EventArgs e)
        {
            dtv_list.DataSource = AllList();
           
            if(!IsAdmin(_loggedInUserid))
            {
                dtv_list.Columns["ID"].Visible = false;
                dtv_list.Columns["User"].Visible = false;
            }
        }

        private void btn_completed_Click(object sender, EventArgs e)
        {
            dtv_list.DataSource = AllList().Where(x => x.StatusDescription == "Completed").ToList();
            //dtv_list.Columns["ID"].Visible = false;
            //dtv_list.Columns["User"].Visible = false;
        }

        private void btn_incompleted_Click(object sender, EventArgs e)
        {
            dtv_list.DataSource = AllList().Where(x => x.StatusDescription == "Incompleted").ToList();
            //dtv_list.Columns["ID"].Visible = false;
            //dtv_list.Columns["User"].Visible = false;
        }

        private void btn_pending_Click(object sender, EventArgs e)
        {
            dtv_list.DataSource = AllList().Where(x => x.StatusDescription == "Pending").ToList();
            //dtv_list.Columns["ID"].Visible = false;
            //dtv_list.Columns["User"].Visible = false;
        }

        private void btn_postponed_Click(object sender, EventArgs e)
        {
            dtv_list.DataSource = AllList().Where(x => x.StatusDescription == "Postponed").ToList();
            //dtv_list.Columns["ID"].Visible = false;
            //dtv_list.Columns["User"].Visible = false;
        }

        private void btn_canceled_Click(object sender, EventArgs e)
        {
            dtv_list.DataSource = AllList().Where(x => x.StatusDescription == "Canceled").ToList();
            //dtv_list.Columns["ID"].Visible = false;
            //dtv_list.Columns["User"].Visible = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
