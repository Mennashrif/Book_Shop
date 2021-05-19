namespace IS_project
{
    partial class regestration_login
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
            this.user_name = new System.Windows.Forms.Label();
            this.user_pass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.user_phone = new System.Windows.Forms.Label();
            this.user_add = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.login_b = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.BackColor = System.Drawing.Color.DarkKhaki;
            this.user_name.Font = new System.Drawing.Font("Algerian", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.user_name.Location = new System.Drawing.Point(44, 88);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(83, 21);
            this.user_name.TabIndex = 0;
            this.user_name.Text = "Name : ";
            this.user_name.Click += new System.EventHandler(this.user_name_Click);
            // 
            // user_pass
            // 
            this.user_pass.AutoSize = true;
            this.user_pass.BackColor = System.Drawing.Color.DarkKhaki;
            this.user_pass.Cursor = System.Windows.Forms.Cursors.Default;
            this.user_pass.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_pass.Location = new System.Drawing.Point(12, 144);
            this.user_pass.Name = "user_pass";
            this.user_pass.Size = new System.Drawing.Size(133, 21);
            this.user_pass.TabIndex = 1;
            this.user_pass.Text = "Password : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(200, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(162, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(196, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // user_phone
            // 
            this.user_phone.AutoSize = true;
            this.user_phone.BackColor = System.Drawing.Color.DarkKhaki;
            this.user_phone.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_phone.Location = new System.Drawing.Point(45, 221);
            this.user_phone.Name = "user_phone";
            this.user_phone.Size = new System.Drawing.Size(91, 21);
            this.user_phone.TabIndex = 5;
            this.user_phone.Text = "Phone : ";
            // 
            // user_add
            // 
            this.user_add.AutoSize = true;
            this.user_add.BackColor = System.Drawing.Color.DarkKhaki;
            this.user_add.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_add.Location = new System.Drawing.Point(28, 277);
            this.user_add.Name = "user_add";
            this.user_add.Size = new System.Drawing.Size(117, 21);
            this.user_add.TabIndex = 6;
            this.user_add.Text = "Address : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(395, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(158, 277);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 22);
            this.textBox4.TabIndex = 8;
            // 
            // login_b
            // 
            this.login_b.BackColor = System.Drawing.Color.DarkKhaki;
            this.login_b.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_b.Location = new System.Drawing.Point(472, 74);
            this.login_b.Name = "login_b";
            this.login_b.Size = new System.Drawing.Size(90, 78);
            this.login_b.TabIndex = 9;
            this.login_b.Text = "Login ";
            this.login_b.UseVisualStyleBackColor = false;
            this.login_b.Click += new System.EventHandler(this.login_b_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.Font = new System.Drawing.Font("Algerian", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(407, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Have account : ";
            // 
            // regestration_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IS_project.Properties.Resources.edinburgh_library;
            this.ClientSize = new System.Drawing.Size(596, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_b);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_add);
            this.Controls.Add(this.user_phone);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.user_pass);
            this.Controls.Add(this.user_name);
            this.Name = "regestration_login";
            this.Text = "regestration_login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.regestration_login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label user_pass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label user_phone;
        private System.Windows.Forms.Label user_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button login_b;
        private System.Windows.Forms.Label label1;
    }
}