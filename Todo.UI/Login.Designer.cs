namespace Todo.UI
{
    partial class Login
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
            label1 = new Label();
            txt_username = new TextBox();
            label2 = new Label();
            txt_password = new TextBox();
            btn_register = new Button();
            btn_login = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(126, 6);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(106, 24);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(125, 23);
            txt_username.TabIndex = 0;
            txt_username.Enter += txt_username_Enter;
            txt_username.Leave += txt_username_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(126, 58);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(106, 76);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(125, 23);
            txt_password.TabIndex = 1;
            txt_password.Enter += txt_username_Enter;
            txt_password.Leave += txt_username_Leave;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.Transparent;
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatAppearance.MouseDownBackColor = Color.Gold;
            btn_register.FlatAppearance.MouseOverBackColor = Color.Gold;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(106, 140);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(125, 30);
            btn_register.TabIndex = 3;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Transparent;
            btn_login.BackgroundImageLayout = ImageLayout.None;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            btn_login.FlatAppearance.MouseOverBackColor = Color.Gold;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(106, 105);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(125, 30);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.TabIndexChanged += btn_login_TabIndexChanged;
            btn_login.TabStopChanged += btn_login_TabStopChanged;
            btn_login.Click += btn_login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(68, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.password;
            pictureBox2.Location = new Point(68, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Transparent;
            btn_close.BackgroundImageLayout = ImageLayout.None;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.ForeColor = Color.White;
            btn_close.Location = new Point(106, 176);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(125, 22);
            btn_close.TabIndex = 4;
            btn_close.Text = "Close";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images_1;
            ClientSize = new Size(335, 210);
            Controls.Add(btn_close);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_login);
            Controls.Add(btn_register);
            Controls.Add(txt_password);
            Controls.Add(label2);
            Controls.Add(txt_username);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_username;
        private Label label2;
        private TextBox txt_password;
        private Button btn_register;
        private Button btn_login;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btn_close;
    }
}