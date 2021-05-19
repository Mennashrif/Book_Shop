namespace IS_project
{
    partial class AdminRegUS
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
            this.security_num = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.admin_address = new System.Windows.Forms.TextBox();
            this.admin_pass = new System.Windows.Forms.TextBox();
            this.admin_name = new System.Windows.Forms.TextBox();
            this.admin_phone = new System.Windows.Forms.TextBox();
            this.user_add = new System.Windows.Forms.Label();
            this.user_phone = new System.Windows.Forms.Label();
            this.user_pass = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // security_num
            // 
            this.security_num.Location = new System.Drawing.Point(359, 368);
            this.security_num.Name = "security_num";
            this.security_num.Size = new System.Drawing.Size(151, 22);
            this.security_num.TabIndex = 43;
            this.security_num.TextChanged += new System.EventHandler(this.security_num_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(299, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 33);
            this.button1.TabIndex = 42;
            this.button1.Text = "Regestration ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // admin_address
            // 
            this.admin_address.Location = new System.Drawing.Point(359, 318);
            this.admin_address.Name = "admin_address";
            this.admin_address.Size = new System.Drawing.Size(151, 22);
            this.admin_address.TabIndex = 41;
            this.admin_address.TextChanged += new System.EventHandler(this.admin_address_TextChanged);
            // 
            // admin_pass
            // 
            this.admin_pass.Location = new System.Drawing.Point(359, 231);
            this.admin_pass.Name = "admin_pass";
            this.admin_pass.PasswordChar = '*';
            this.admin_pass.Size = new System.Drawing.Size(151, 22);
            this.admin_pass.TabIndex = 40;
            this.admin_pass.TextChanged += new System.EventHandler(this.admin_pass_TextChanged);
            // 
            // admin_name
            // 
            this.admin_name.Location = new System.Drawing.Point(359, 184);
            this.admin_name.Name = "admin_name";
            this.admin_name.Size = new System.Drawing.Size(151, 22);
            this.admin_name.TabIndex = 39;
            this.admin_name.TextChanged += new System.EventHandler(this.admin_name_TextChanged);
            // 
            // admin_phone
            // 
            this.admin_phone.Location = new System.Drawing.Point(359, 272);
            this.admin_phone.Name = "admin_phone";
            this.admin_phone.Size = new System.Drawing.Size(151, 22);
            this.admin_phone.TabIndex = 38;
            this.admin_phone.TextChanged += new System.EventHandler(this.admin_phone_TextChanged);
            // 
            // user_add
            // 
            this.user_add.AutoSize = true;
            this.user_add.BackColor = System.Drawing.Color.RosyBrown;
            this.user_add.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_add.Location = new System.Drawing.Point(146, 319);
            this.user_add.Name = "user_add";
            this.user_add.Size = new System.Drawing.Size(117, 21);
            this.user_add.TabIndex = 47;
            this.user_add.Text = "Address : ";
            // 
            // user_phone
            // 
            this.user_phone.AutoSize = true;
            this.user_phone.BackColor = System.Drawing.Color.RosyBrown;
            this.user_phone.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_phone.Location = new System.Drawing.Point(172, 272);
            this.user_phone.Name = "user_phone";
            this.user_phone.Size = new System.Drawing.Size(91, 21);
            this.user_phone.TabIndex = 46;
            this.user_phone.Text = "Phone : ";
            // 
            // user_pass
            // 
            this.user_pass.AutoSize = true;
            this.user_pass.BackColor = System.Drawing.Color.RosyBrown;
            this.user_pass.Cursor = System.Windows.Forms.Cursors.Default;
            this.user_pass.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_pass.Location = new System.Drawing.Point(154, 232);
            this.user_pass.Name = "user_pass";
            this.user_pass.Size = new System.Drawing.Size(133, 21);
            this.user_pass.TabIndex = 45;
            this.user_pass.Text = "Password : ";
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.BackColor = System.Drawing.Color.RosyBrown;
            this.user_name.Font = new System.Drawing.Font("Algerian", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.user_name.Location = new System.Drawing.Point(172, 184);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(83, 21);
            this.user_name.TabIndex = 44;
            this.user_name.Text = "Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "security number";
            // 
            // AdminRegUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IS_project.Properties.Resources.photo_14;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_add);
            this.Controls.Add(this.user_phone);
            this.Controls.Add(this.user_pass);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.security_num);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.admin_address);
            this.Controls.Add(this.admin_pass);
            this.Controls.Add(this.admin_name);
            this.Controls.Add(this.admin_phone);
            this.Name = "AdminRegUS";
            this.Size = new System.Drawing.Size(741, 688);
            this.Load += new System.EventHandler(this.AdminRegUS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox security_num;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox admin_address;
        private System.Windows.Forms.TextBox admin_pass;
        private System.Windows.Forms.TextBox admin_name;
        private System.Windows.Forms.TextBox admin_phone;
        private System.Windows.Forms.Label user_add;
        private System.Windows.Forms.Label user_phone;
        private System.Windows.Forms.Label user_pass;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label label1;
    }
}
