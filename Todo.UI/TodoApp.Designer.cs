namespace Todo.UI
{
    partial class TodoApp
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            grp_buttonstodo = new GroupBox();
            btn_showlist = new Button();
            btn_update = new Button();
            btn_newreg = new Button();
            btn_remove = new Button();
            btn_close = new Button();
            lbl_timer = new Label();
            pictureBox1 = new PictureBox();
            btn_operations = new Button();
            tmr = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            grp_buttonstodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.arkaplanturuncu;
            panel1.Controls.Add(grp_buttonstodo);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_operations);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 366);
            panel1.TabIndex = 0;
            // 
            // grp_buttonstodo
            // 
            grp_buttonstodo.BackgroundImageLayout = ImageLayout.None;
            grp_buttonstodo.Controls.Add(btn_showlist);
            grp_buttonstodo.Controls.Add(btn_update);
            grp_buttonstodo.Controls.Add(btn_newreg);
            grp_buttonstodo.Controls.Add(btn_remove);
            grp_buttonstodo.Controls.Add(btn_close);
            grp_buttonstodo.Controls.Add(lbl_timer);
            grp_buttonstodo.Location = new Point(12, 201);
            grp_buttonstodo.Name = "grp_buttonstodo";
            grp_buttonstodo.Size = new Size(135, 153);
            grp_buttonstodo.TabIndex = 6;
            grp_buttonstodo.TabStop = false;
            // 
            // btn_showlist
            // 
            btn_showlist.FlatAppearance.BorderSize = 0;
            btn_showlist.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btn_showlist.FlatStyle = FlatStyle.Flat;
            btn_showlist.ForeColor = Color.FromArgb(0, 0, 192);
            btn_showlist.Location = new Point(0, 38);
            btn_showlist.Name = "btn_showlist";
            btn_showlist.Size = new Size(135, 23);
            btn_showlist.TabIndex = 2;
            btn_showlist.Text = "Show List";
            btn_showlist.UseVisualStyleBackColor = true;
            btn_showlist.Click += btn_showlist_Click;
            // 
            // btn_update
            // 
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.ForeColor = Color.Blue;
            btn_update.Location = new Point(0, 67);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(135, 23);
            btn_update.TabIndex = 5;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_newreg
            // 
            btn_newreg.FlatAppearance.BorderSize = 0;
            btn_newreg.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            btn_newreg.FlatStyle = FlatStyle.Flat;
            btn_newreg.ForeColor = Color.Blue;
            btn_newreg.Location = new Point(0, 9);
            btn_newreg.Name = "btn_newreg";
            btn_newreg.Size = new Size(135, 23);
            btn_newreg.TabIndex = 1;
            btn_newreg.Text = "New Register";
            btn_newreg.UseVisualStyleBackColor = true;
            btn_newreg.Click += btn_newreg_Click;
            // 
            // btn_remove
            // 
            btn_remove.FlatAppearance.BorderSize = 0;
            btn_remove.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btn_remove.FlatStyle = FlatStyle.Flat;
            btn_remove.ForeColor = Color.Blue;
            btn_remove.Location = new Point(0, 96);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(135, 23);
            btn_remove.TabIndex = 5;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_close
            // 
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.ForeColor = Color.Blue;
            btn_close.Location = new Point(0, 126);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(135, 23);
            btn_close.TabIndex = 2;
            btn_close.Text = "Close";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // lbl_timer
            // 
            lbl_timer.AutoSize = true;
            lbl_timer.ForeColor = Color.Cyan;
            lbl_timer.Location = new Point(46, 134);
            lbl_timer.Name = "lbl_timer";
            lbl_timer.Size = new Size(0, 15);
            lbl_timer.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Papirus_Team_Papirus_Apps_Gnome_todo_512;
            pictureBox1.Location = new Point(12, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_operations
            // 
            btn_operations.BackColor = Color.FromArgb(128, 255, 128);
            btn_operations.BackgroundImageLayout = ImageLayout.None;
            btn_operations.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btn_operations.FlatAppearance.BorderSize = 0;
            btn_operations.FlatStyle = FlatStyle.Flat;
            btn_operations.Location = new Point(12, 176);
            btn_operations.Name = "btn_operations";
            btn_operations.Size = new Size(135, 28);
            btn_operations.TabIndex = 0;
            btn_operations.Text = "İşlem Listesi";
            btn_operations.UseVisualStyleBackColor = false;
            btn_operations.Click += btn_operations_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCoral;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(154, 42);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "TODO APP";
            // 
            // TodoApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(154, 366);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "TodoApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TodoApp";
            Load += TodoApp_Load;
            panel1.ResumeLayout(false);
            grp_buttonstodo.ResumeLayout(false);
            grp_buttonstodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_close;
        private Button btn_showlist;
        private Button btn_newreg;
        private Button btn_operations;
        private Label lbl_timer;
        private System.Windows.Forms.Timer tmr;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private GroupBox grp_buttonstodo;
        private Button btn_update;
        private Button btn_remove;
    }
}