namespace IS_project
{
    partial class User_log
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
            this.login_b = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.user_log_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_b
            // 
            this.login_b.BackColor = System.Drawing.Color.RosyBrown;
            this.login_b.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold);
            this.login_b.Location = new System.Drawing.Point(254, 349);
            this.login_b.Name = "login_b";
            this.login_b.Size = new System.Drawing.Size(145, 46);
            this.login_b.TabIndex = 9;
            this.login_b.Text = "Login ";
            this.login_b.UseVisualStyleBackColor = false;
            this.login_b.Click += new System.EventHandler(this.login_b_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pass_text
            // 
            this.pass_text.Location = new System.Drawing.Point(254, 277);
            this.pass_text.Name = "pass_text";
            this.pass_text.PasswordChar = '*';
            this.pass_text.Size = new System.Drawing.Size(197, 22);
            this.pass_text.TabIndex = 7;
            // 
            // user_log_text
            // 
            this.user_log_text.Location = new System.Drawing.Point(254, 201);
            this.user_log_text.Name = "user_log_text";
            this.user_log_text.Size = new System.Drawing.Size(197, 22);
            this.user_log_text.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserName : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // User_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IS_project.Properties.Resources.photo_14;
            this.Controls.Add(this.login_b);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.user_log_text);
            this.Controls.Add(this.label1);
            this.Name = "User_log";
            this.Size = new System.Drawing.Size(548, 447);
            this.Load += new System.EventHandler(this.User_log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.TextBox user_log_text;
        private System.Windows.Forms.Label label1;
    }
}
