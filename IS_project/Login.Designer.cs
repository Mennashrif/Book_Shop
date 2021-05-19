namespace IS_project
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
            this.label1 = new System.Windows.Forms.Label();
            this.user_log_text = new System.Windows.Forms.TextBox();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_b = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // user_log_text
            // 
            this.user_log_text.Location = new System.Drawing.Point(180, 117);
            this.user_log_text.Name = "user_log_text";
            this.user_log_text.Size = new System.Drawing.Size(197, 22);
            this.user_log_text.TabIndex = 1;
            this.user_log_text.TextChanged += new System.EventHandler(this.user_log_text_TextChanged);
            // 
            // pass_text
            // 
            this.pass_text.Location = new System.Drawing.Point(180, 193);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(197, 22);
            this.pass_text.TabIndex = 2;
            this.pass_text.TextChanged += new System.EventHandler(this.pass_text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkKhaki;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // login_b
            // 
            this.login_b.BackColor = System.Drawing.Color.DarkKhaki;
            this.login_b.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_b.Location = new System.Drawing.Point(217, 243);
            this.login_b.Name = "login_b";
            this.login_b.Size = new System.Drawing.Size(117, 36);
            this.login_b.TabIndex = 4;
            this.login_b.Text = "Login ";
            this.login_b.UseVisualStyleBackColor = false;
            this.login_b.Click += new System.EventHandler(this.login_b_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IS_project.Properties.Resources.edinburgh_library;
            this.ClientSize = new System.Drawing.Size(576, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.login_b);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.user_log_text);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_log_text;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_b;
        private System.Windows.Forms.Button button1;
    }
}