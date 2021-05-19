namespace IS_project
{
    partial class UserReg
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.user_add = new System.Windows.Forms.Label();
            this.user_phone = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.user_pass = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.RadioButton();
            this.credit = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(256, 397);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 22);
            this.textBox4.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(499, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_add
            // 
            this.user_add.AutoSize = true;
            this.user_add.BackColor = System.Drawing.Color.RosyBrown;
            this.user_add.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_add.Location = new System.Drawing.Point(109, 398);
            this.user_add.Name = "user_add";
            this.user_add.Size = new System.Drawing.Size(117, 21);
            this.user_add.TabIndex = 15;
            this.user_add.Text = "Address : ";
            this.user_add.Click += new System.EventHandler(this.user_add_Click);
            // 
            // user_phone
            // 
            this.user_phone.AutoSize = true;
            this.user_phone.BackColor = System.Drawing.Color.RosyBrown;
            this.user_phone.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_phone.Location = new System.Drawing.Point(117, 334);
            this.user_phone.Name = "user_phone";
            this.user_phone.Size = new System.Drawing.Size(91, 21);
            this.user_phone.TabIndex = 14;
            this.user_phone.Text = "Phone : ";
            this.user_phone.Click += new System.EventHandler(this.user_phone_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(260, 231);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(196, 22);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 274);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(200, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 11;
            // 
            // user_pass
            // 
            this.user_pass.AutoSize = true;
            this.user_pass.BackColor = System.Drawing.Color.RosyBrown;
            this.user_pass.Cursor = System.Windows.Forms.Cursors.Default;
            this.user_pass.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_pass.Location = new System.Drawing.Point(109, 275);
            this.user_pass.Name = "user_pass";
            this.user_pass.Size = new System.Drawing.Size(133, 21);
            this.user_pass.TabIndex = 10;
            this.user_pass.Text = "Password : ";
            this.user_pass.Click += new System.EventHandler(this.user_pass_Click);
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.BackColor = System.Drawing.Color.RosyBrown;
            this.user_name.Font = new System.Drawing.Font("Algerian", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.user_name.Location = new System.Drawing.Point(125, 232);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(83, 21);
            this.user_name.TabIndex = 9;
            this.user_name.Text = "Name : ";
            this.user_name.Click += new System.EventHandler(this.user_name_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(260, 189);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(196, 22);
            this.email.TabIndex = 18;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Algerian", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(125, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Email :";
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.BackColor = System.Drawing.Color.RosyBrown;
            this.cash.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Bold);
            this.cash.Location = new System.Drawing.Point(348, 440);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(83, 25);
            this.cash.TabIndex = 20;
            this.cash.TabStop = true;
            this.cash.Text = "Cash";
            this.cash.UseVisualStyleBackColor = false;
            this.cash.CheckedChanged += new System.EventHandler(this.cash_CheckedChanged);
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.BackColor = System.Drawing.Color.RosyBrown;
            this.credit.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Bold);
            this.credit.Location = new System.Drawing.Point(486, 442);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(118, 25);
            this.credit.TabIndex = 21;
            this.credit.TabStop = true;
            this.credit.Text = "Credit : ";
            this.credit.UseVisualStyleBackColor = false;
            this.credit.CheckedChanged += new System.EventHandler(this.credit_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Way of payment : ";
            // 
            // UserReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IS_project.Properties.Resources.photo_14;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_add);
            this.Controls.Add(this.user_phone);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.user_pass);
            this.Controls.Add(this.user_name);
            this.Name = "UserReg";
            this.Size = new System.Drawing.Size(741, 688);
            this.Load += new System.EventHandler(this.UserReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label user_add;
        private System.Windows.Forms.Label user_phone;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label user_pass;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton cash;
        private System.Windows.Forms.RadioButton credit;
        private System.Windows.Forms.Label label2;
    }
}
