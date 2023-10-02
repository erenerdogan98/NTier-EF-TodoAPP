namespace Todo.UI
{
    partial class Register
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
            btn_reg = new Button();
            label1 = new Label();
            txt_username = new TextBox();
            label2 = new Label();
            txt_password = new TextBox();
            txt_email = new TextBox();
            label3 = new Label();
            txt_phone = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            cmb_userrole = new ComboBox();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_reg
            // 
            btn_reg.BackColor = Color.Transparent;
            btn_reg.BackgroundImageLayout = ImageLayout.None;
            btn_reg.FlatAppearance.BorderSize = 0;
            btn_reg.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn_reg.FlatStyle = FlatStyle.Flat;
            btn_reg.ForeColor = Color.Green;
            btn_reg.Location = new Point(211, 168);
            btn_reg.Name = "btn_reg";
            btn_reg.Size = new Size(100, 33);
            btn_reg.TabIndex = 5;
            btn_reg.Text = "Register";
            btn_reg.UseVisualStyleBackColor = false;
            btn_reg.Click += btn_reg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(136, 20);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(211, 17);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(100, 23);
            txt_username.TabIndex = 0;
            txt_username.Enter += txt_username_Enter;
            txt_username.Leave += txt_username_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(136, 50);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(211, 46);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(100, 23);
            txt_password.TabIndex = 1;
            txt_password.Enter += txt_username_Enter;
            txt_password.Leave += txt_username_Leave;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(211, 75);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(100, 23);
            txt_email.TabIndex = 2;
            txt_email.Enter += txt_username_Enter;
            txt_email.Leave += txt_username_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(136, 79);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(211, 104);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(100, 23);
            txt_phone.TabIndex = 3;
            txt_phone.Enter += txt_username_Enter;
            txt_phone.Leave += txt_username_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(136, 108);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_user_group_new_256;
            pictureBox1.Location = new Point(12, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(142, 136);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 5;
            label5.Text = "User Role";
            // 
            // cmb_userrole
            // 
            cmb_userrole.FormattingEnabled = true;
            cmb_userrole.Items.AddRange(new object[] { "User", "Admin" });
            cmb_userrole.Location = new Point(211, 133);
            cmb_userrole.Name = "cmb_userrole";
            cmb_userrole.Size = new Size(100, 23);
            cmb_userrole.TabIndex = 4;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = Color.Red;
            btn_back.Location = new Point(12, 168);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(84, 33);
            btn_back.TabIndex = 6;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images_1;
            ClientSize = new Size(334, 202);
            Controls.Add(btn_back);
            Controls.Add(cmb_userrole);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_phone);
            Controls.Add(txt_email);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label1);
            Controls.Add(btn_reg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_reg;
        private Label label1;
        private TextBox txt_username;
        private Label label2;
        private TextBox txt_password;
        private TextBox txt_email;
        private Label label3;
        private TextBox txt_phone;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private ComboBox cmb_userrole;
        private Button btn_back;
    }
}