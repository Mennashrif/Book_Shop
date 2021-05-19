namespace IS_project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_log_pass = new System.Windows.Forms.TextBox();
            this.admin_log_name = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.login_admin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.use_log = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(45, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 39);
            this.button1.TabIndex = 35;
            this.button1.Text = "Admin Reg";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Name ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // admin_log_pass
            // 
            this.admin_log_pass.Location = new System.Drawing.Point(196, 86);
            this.admin_log_pass.Name = "admin_log_pass";
            this.admin_log_pass.PasswordChar = '*';
            this.admin_log_pass.Size = new System.Drawing.Size(100, 22);
            this.admin_log_pass.TabIndex = 28;
            // 
            // admin_log_name
            // 
            this.admin_log_name.Location = new System.Drawing.Point(80, 86);
            this.admin_log_name.Name = "admin_log_name";
            this.admin_log_name.Size = new System.Drawing.Size(100, 22);
            this.admin_log_name.TabIndex = 27;
            this.admin_log_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(45, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 42);
            this.button2.TabIndex = 25;
            this.button2.Text = "User Reg";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // login_admin
            // 
            this.login_admin.BackColor = System.Drawing.Color.RosyBrown;
            this.login_admin.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.login_admin.Location = new System.Drawing.Point(94, 132);
            this.login_admin.Name = "login_admin";
            this.login_admin.Size = new System.Drawing.Size(148, 34);
            this.login_admin.TabIndex = 36;
            this.login_admin.Text = "login ";
            this.login_admin.UseVisualStyleBackColor = false;
            this.login_admin.Click += new System.EventHandler(this.login_admin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkKhaki;
            this.label3.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 37);
            this.label3.TabIndex = 38;
            this.label3.Text = "If you are admin : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkKhaki;
            this.label4.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 37);
            this.label4.TabIndex = 39;
            this.label4.Text = "If you are User  : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(335, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 688);
            this.panel1.TabIndex = 40;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // use_log
            // 
            this.use_log.BackColor = System.Drawing.Color.RosyBrown;
            this.use_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.use_log.Location = new System.Drawing.Point(45, 511);
            this.use_log.Name = "use_log";
            this.use_log.Size = new System.Drawing.Size(148, 39);
            this.use_log.TabIndex = 41;
            this.use_log.Text = "User Login";
            this.use_log.UseVisualStyleBackColor = false;
            this.use_log.Click += new System.EventHandler(this.use_log_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::IS_project.Properties.Resources.photo_14;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::IS_project.Properties.Resources.photo_1481627834876_b7833e8f5570;
            this.ClientSize = new System.Drawing.Size(1076, 684);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.use_log);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_admin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admin_log_pass);
            this.Controls.Add(this.admin_log_name);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox admin_log_pass;
        private System.Windows.Forms.TextBox admin_log_name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button login_admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button use_log;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

