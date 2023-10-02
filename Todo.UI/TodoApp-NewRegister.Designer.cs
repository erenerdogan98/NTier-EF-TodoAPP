namespace Todo.UI
{
    partial class TodoApp_NewRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodoApp_NewRegister));
            panel1 = new Panel();
            btn_close = new Button();
            label6 = new Label();
            panel2 = new Panel();
            btn_newreg = new Button();
            cmb_status = new ComboBox();
            txt_description = new TextBox();
            label3 = new Label();
            txt_shortdescription = new TextBox();
            label2 = new Label();
            txt_importance = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_title = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(btn_close);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 49);
            panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            btn_close.BackgroundImage = (Image)resources.GetObject("btn_close.BackgroundImage");
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Location = new Point(321, 0);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(46, 45);
            btn_close.TabIndex = 1;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(15, 8);
            label6.Name = "label6";
            label6.Size = new Size(218, 30);
            label6.TabIndex = 0;
            label6.Text = "Todo App Registration";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(btn_newreg);
            panel2.Controls.Add(cmb_status);
            panel2.Controls.Add(txt_description);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_shortdescription);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_importance);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txt_title);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 281);
            panel2.TabIndex = 1;
            // 
            // btn_newreg
            // 
            btn_newreg.BackColor = Color.Transparent;
            btn_newreg.BackgroundImageLayout = ImageLayout.None;
            btn_newreg.FlatAppearance.BorderSize = 0;
            btn_newreg.FlatAppearance.MouseDownBackColor = Color.Indigo;
            btn_newreg.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btn_newreg.FlatStyle = FlatStyle.Flat;
            btn_newreg.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_newreg.ForeColor = Color.Yellow;
            btn_newreg.Location = new Point(119, 246);
            btn_newreg.Name = "btn_newreg";
            btn_newreg.Size = new Size(233, 32);
            btn_newreg.TabIndex = 5;
            btn_newreg.Text = "New Register";
            btn_newreg.UseVisualStyleBackColor = false;
            btn_newreg.Click += btn_newreg_Click;
            btn_newreg.MouseEnter += btn_newreg_MouseEnter;
            btn_newreg.MouseLeave += btn_newreg_MouseEnter;
            btn_newreg.MouseMove += btn_newreg_MouseMove;
            // 
            // cmb_status
            // 
            cmb_status.FormattingEnabled = true;
            cmb_status.Items.AddRange(new object[] { "Pending", "Completed", "Incomplete", "Canceled", "Postponed" });
            cmb_status.Location = new Point(119, 222);
            cmb_status.Name = "cmb_status";
            cmb_status.Size = new Size(233, 23);
            cmb_status.TabIndex = 4;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(119, 94);
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(233, 90);
            txt_description.TabIndex = 2;
            txt_description.Enter += txt_title_Enter;
            txt_description.Leave += txt_title_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Chartreuse;
            label3.Location = new Point(15, 97);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 0;
            label3.Text = "Description";
            // 
            // txt_shortdescription
            // 
            txt_shortdescription.Location = new Point(119, 39);
            txt_shortdescription.Multiline = true;
            txt_shortdescription.Name = "txt_shortdescription";
            txt_shortdescription.Size = new Size(233, 49);
            txt_shortdescription.TabIndex = 1;
            txt_shortdescription.Enter += txt_title_Enter;
            txt_shortdescription.Leave += txt_title_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Chartreuse;
            label2.Location = new Point(15, 42);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Short Description";
            // 
            // txt_importance
            // 
            txt_importance.Location = new Point(119, 190);
            txt_importance.Name = "txt_importance";
            txt_importance.Size = new Size(233, 23);
            txt_importance.TabIndex = 3;
            txt_importance.Enter += txt_title_Enter;
            txt_importance.Leave += txt_title_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Chartreuse;
            label4.Location = new Point(15, 193);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 0;
            label4.Text = "Importance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Chartreuse;
            label5.Location = new Point(15, 222);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 0;
            label5.Text = "Status";
            // 
            // txt_title
            // 
            txt_title.Location = new Point(119, 10);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(233, 23);
            txt_title.TabIndex = 0;
            txt_title.Enter += txt_title_Enter;
            txt_title.Leave += txt_title_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Chartreuse;
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // TodoApp_NewRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 330);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TodoApp_NewRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TodoApp_NewRegister";
            Load += TodoApp_NewRegister_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ComboBox cmb_status;
        private TextBox txt_description;
        private Label label3;
        private TextBox txt_shortdescription;
        private Label label2;
        private TextBox txt_importance;
        private Label label4;
        private Label label5;
        private TextBox txt_title;
        private Label label1;
        private Button btn_newreg;
        private Button btn_close;
        private Label label6;
    }
}