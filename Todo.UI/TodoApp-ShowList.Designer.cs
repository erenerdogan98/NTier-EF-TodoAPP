namespace Todo.UI
{
    partial class TodoApp_ShowList
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
            panel1 = new Panel();
            grp_buttons = new GroupBox();
            btn_Close = new Button();
            btn_canceled = new Button();
            btn_postponed = new Button();
            btn_pending = new Button();
            btn_incompleted = new Button();
            btn_completed = new Button();
            btn_alllist = new Button();
            btn_operations = new Button();
            panel2 = new Panel();
            dtv_list = new DataGridView();
            panel1.SuspendLayout();
            grp_buttons.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtv_list).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OliveDrab;
            panel1.Controls.Add(grp_buttons);
            panel1.Controls.Add(btn_operations);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 377);
            panel1.TabIndex = 0;
            // 
            // grp_buttons
            // 
            grp_buttons.Controls.Add(btn_Close);
            grp_buttons.Controls.Add(btn_canceled);
            grp_buttons.Controls.Add(btn_postponed);
            grp_buttons.Controls.Add(btn_pending);
            grp_buttons.Controls.Add(btn_incompleted);
            grp_buttons.Controls.Add(btn_completed);
            grp_buttons.Controls.Add(btn_alllist);
            grp_buttons.FlatStyle = FlatStyle.Flat;
            grp_buttons.Location = new Point(3, 105);
            grp_buttons.Name = "grp_buttons";
            grp_buttons.Size = new Size(191, 260);
            grp_buttons.TabIndex = 2;
            grp_buttons.TabStop = false;
            // 
            // btn_Close
            // 
            btn_Close.FlatAppearance.BorderColor = Color.Red;
            btn_Close.FlatAppearance.BorderSize = 3;
            btn_Close.FlatAppearance.MouseDownBackColor = Color.Red;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Location = new Point(29, 196);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(118, 40);
            btn_Close.TabIndex = 8;
            btn_Close.Text = "CLOSE";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_canceled
            // 
            btn_canceled.FlatAppearance.BorderSize = 0;
            btn_canceled.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btn_canceled.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btn_canceled.FlatStyle = FlatStyle.Flat;
            btn_canceled.ForeColor = Color.White;
            btn_canceled.Location = new Point(29, 167);
            btn_canceled.Name = "btn_canceled";
            btn_canceled.Size = new Size(118, 23);
            btn_canceled.TabIndex = 2;
            btn_canceled.Text = "Canceled";
            btn_canceled.UseVisualStyleBackColor = true;
            btn_canceled.Click += btn_canceled_Click;
            // 
            // btn_postponed
            // 
            btn_postponed.FlatAppearance.BorderSize = 0;
            btn_postponed.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btn_postponed.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btn_postponed.FlatStyle = FlatStyle.Flat;
            btn_postponed.ForeColor = Color.White;
            btn_postponed.Location = new Point(29, 138);
            btn_postponed.Name = "btn_postponed";
            btn_postponed.Size = new Size(118, 23);
            btn_postponed.TabIndex = 3;
            btn_postponed.Text = "Postponed";
            btn_postponed.UseVisualStyleBackColor = true;
            btn_postponed.Click += btn_postponed_Click;
            // 
            // btn_pending
            // 
            btn_pending.FlatAppearance.BorderSize = 0;
            btn_pending.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btn_pending.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btn_pending.FlatStyle = FlatStyle.Flat;
            btn_pending.ForeColor = Color.White;
            btn_pending.Location = new Point(29, 109);
            btn_pending.Name = "btn_pending";
            btn_pending.Size = new Size(118, 23);
            btn_pending.TabIndex = 4;
            btn_pending.Text = "Pending";
            btn_pending.UseVisualStyleBackColor = true;
            btn_pending.Click += btn_pending_Click;
            // 
            // btn_incompleted
            // 
            btn_incompleted.FlatAppearance.BorderSize = 0;
            btn_incompleted.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btn_incompleted.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btn_incompleted.FlatStyle = FlatStyle.Flat;
            btn_incompleted.ForeColor = Color.White;
            btn_incompleted.Location = new Point(29, 80);
            btn_incompleted.Name = "btn_incompleted";
            btn_incompleted.Size = new Size(118, 23);
            btn_incompleted.TabIndex = 5;
            btn_incompleted.Text = "Incompleted";
            btn_incompleted.UseVisualStyleBackColor = true;
            btn_incompleted.Click += btn_incompleted_Click;
            // 
            // btn_completed
            // 
            btn_completed.BackgroundImageLayout = ImageLayout.None;
            btn_completed.FlatAppearance.BorderSize = 0;
            btn_completed.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btn_completed.FlatStyle = FlatStyle.Flat;
            btn_completed.ForeColor = Color.White;
            btn_completed.Location = new Point(29, 51);
            btn_completed.Name = "btn_completed";
            btn_completed.Size = new Size(118, 23);
            btn_completed.TabIndex = 6;
            btn_completed.Text = "Completed";
            btn_completed.UseVisualStyleBackColor = true;
            btn_completed.Click += btn_completed_Click;
            // 
            // btn_alllist
            // 
            btn_alllist.BackgroundImageLayout = ImageLayout.None;
            btn_alllist.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            btn_alllist.FlatAppearance.BorderSize = 0;
            btn_alllist.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btn_alllist.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btn_alllist.FlatStyle = FlatStyle.Flat;
            btn_alllist.ForeColor = Color.White;
            btn_alllist.Location = new Point(29, 22);
            btn_alllist.Name = "btn_alllist";
            btn_alllist.Size = new Size(118, 23);
            btn_alllist.TabIndex = 7;
            btn_alllist.Text = "All List";
            btn_alllist.UseVisualStyleBackColor = true;
            btn_alllist.Click += btn_alllist_Click;
            // 
            // btn_operations
            // 
            btn_operations.BackColor = Color.Transparent;
            btn_operations.BackgroundImageLayout = ImageLayout.None;
            btn_operations.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 128);
            btn_operations.FlatAppearance.BorderSize = 4;
            btn_operations.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btn_operations.FlatStyle = FlatStyle.Flat;
            btn_operations.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_operations.ForeColor = Color.GhostWhite;
            btn_operations.Location = new Point(12, 45);
            btn_operations.Name = "btn_operations";
            btn_operations.Size = new Size(162, 54);
            btn_operations.TabIndex = 0;
            btn_operations.Text = "Operations";
            btn_operations.UseVisualStyleBackColor = false;
            btn_operations.Click += btn_operations_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSpringGreen;
            panel2.Controls.Add(dtv_list);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 377);
            panel2.TabIndex = 1;
            // 
            // dtv_list
            // 
            dtv_list.BackgroundColor = Color.MediumSpringGreen;
            dtv_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtv_list.Dock = DockStyle.Fill;
            dtv_list.Location = new Point(0, 0);
            dtv_list.Name = "dtv_list";
            dtv_list.RowTemplate.Height = 25;
            dtv_list.Size = new Size(424, 377);
            dtv_list.TabIndex = 0;
            // 
            // TodoApp_ShowList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 377);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TodoApp_ShowList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TodoApp_ShowList";
            Load += TodoApp_ShowList_Load;
            panel1.ResumeLayout(false);
            grp_buttons.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtv_list).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dtv_list;
        private Button btn_operations;
        private GroupBox grp_buttons;
        private Button btn_canceled;
        private Button btn_postponed;
        private Button btn_pending;
        private Button btn_incompleted;
        private Button btn_completed;
        private Button btn_alllist;
        private Button btn_Close;
    }
}