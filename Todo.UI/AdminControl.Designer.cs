namespace Todo.UI
{
    partial class AdminControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_showlist = new Button();
            btn_adminrequest = new Button();
            panel1 = new Panel();
            dgv_adminrequests = new DataGridView();
            panel2 = new Panel();
            btn_userlist = new Button();
            btn_Reject = new Button();
            btn_Accept = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_adminrequests).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_showlist
            // 
            btn_showlist.BackColor = Color.Transparent;
            btn_showlist.FlatAppearance.BorderSize = 0;
            btn_showlist.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btn_showlist.FlatStyle = FlatStyle.Flat;
            btn_showlist.ForeColor = Color.Yellow;
            btn_showlist.Location = new Point(12, 117);
            btn_showlist.Name = "btn_showlist";
            btn_showlist.Size = new Size(156, 39);
            btn_showlist.TabIndex = 0;
            btn_showlist.Text = "Show Todo List";
            btn_showlist.UseVisualStyleBackColor = false;
            btn_showlist.Click += btn_showlist_Click;
            // 
            // btn_adminrequest
            // 
            btn_adminrequest.BackColor = Color.Transparent;
            btn_adminrequest.FlatAppearance.BorderColor = Color.Yellow;
            btn_adminrequest.FlatAppearance.BorderSize = 2;
            btn_adminrequest.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btn_adminrequest.FlatStyle = FlatStyle.Flat;
            btn_adminrequest.ForeColor = Color.Yellow;
            btn_adminrequest.Location = new Point(12, 26);
            btn_adminrequest.Name = "btn_adminrequest";
            btn_adminrequest.Size = new Size(157, 38);
            btn_adminrequest.TabIndex = 1;
            btn_adminrequest.Text = "Admin Requests";
            btn_adminrequest.UseVisualStyleBackColor = false;
            btn_adminrequest.Click += btn_adminrequest_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgv_adminrequests);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(175, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 285);
            panel1.TabIndex = 2;
            // 
            // dgv_adminrequests
            // 
            dgv_adminrequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_adminrequests.Dock = DockStyle.Fill;
            dgv_adminrequests.Location = new Point(0, 0);
            dgv_adminrequests.Name = "dgv_adminrequests";
            dgv_adminrequests.RowTemplate.Height = 25;
            dgv_adminrequests.Size = new Size(374, 285);
            dgv_adminrequests.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.images_1;
            panel2.Controls.Add(btn_userlist);
            panel2.Controls.Add(btn_Reject);
            panel2.Controls.Add(btn_Accept);
            panel2.Controls.Add(btn_showlist);
            panel2.Controls.Add(btn_adminrequest);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 285);
            panel2.TabIndex = 3;
            // 
            // btn_userlist
            // 
            btn_userlist.BackColor = Color.Transparent;
            btn_userlist.FlatAppearance.BorderSize = 0;
            btn_userlist.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btn_userlist.FlatStyle = FlatStyle.Flat;
            btn_userlist.ForeColor = Color.Yellow;
            btn_userlist.Location = new Point(12, 162);
            btn_userlist.Name = "btn_userlist";
            btn_userlist.Size = new Size(156, 40);
            btn_userlist.TabIndex = 3;
            btn_userlist.Text = "Show User List";
            btn_userlist.UseVisualStyleBackColor = false;
            btn_userlist.Click += button1_Click;
            // 
            // btn_Reject
            // 
            btn_Reject.BackColor = Color.Transparent;
            btn_Reject.FlatAppearance.BorderSize = 0;
            btn_Reject.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_Reject.FlatStyle = FlatStyle.Flat;
            btn_Reject.ForeColor = Color.White;
            btn_Reject.Location = new Point(93, 70);
            btn_Reject.Name = "btn_Reject";
            btn_Reject.Size = new Size(75, 31);
            btn_Reject.TabIndex = 2;
            btn_Reject.Text = "Reject";
            btn_Reject.UseVisualStyleBackColor = false;
            btn_Reject.Click += btn_Reject_Click;
            // 
            // btn_Accept
            // 
            btn_Accept.BackColor = Color.Transparent;
            btn_Accept.BackgroundImageLayout = ImageLayout.None;
            btn_Accept.FlatAppearance.BorderSize = 0;
            btn_Accept.FlatAppearance.MouseOverBackColor = Color.Lime;
            btn_Accept.FlatStyle = FlatStyle.Flat;
            btn_Accept.ForeColor = Color.White;
            btn_Accept.Location = new Point(12, 70);
            btn_Accept.Name = "btn_Accept";
            btn_Accept.Size = new Size(75, 31);
            btn_Accept.TabIndex = 2;
            btn_Accept.Text = "Accept";
            btn_Accept.UseVisualStyleBackColor = false;
            btn_Accept.Click += btn_Accept_Click;
            // 
            // AdminControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 285);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminControl";
            Load += AdminControl_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_adminrequests).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_showlist;
        private Button btn_adminrequest;
        private Panel panel1;
        private DataGridView dgv_adminrequests;
        private Panel panel2;
        private Button btn_Reject;
        private Button btn_Accept;
        private Button btn_userlist;
    }
}