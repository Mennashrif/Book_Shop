namespace IS_project
{
    partial class add_book_u_s
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
            this.book_name = new System.Windows.Forms.TextBox();
            this.book_cat = new System.Windows.Forms.TextBox();
            this.book_price = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.author_birth = new System.Windows.Forms.TextBox();
            this.author_nat = new System.Windows.Forms.TextBox();
            this.author_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // book_name
            // 
            this.book_name.Location = new System.Drawing.Point(213, 81);
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(153, 22);
            this.book_name.TabIndex = 0;
            this.book_name.TextChanged += new System.EventHandler(this.book_name_TextChanged);
            // 
            // book_cat
            // 
            this.book_cat.Location = new System.Drawing.Point(213, 164);
            this.book_cat.Name = "book_cat";
            this.book_cat.Size = new System.Drawing.Size(153, 22);
            this.book_cat.TabIndex = 2;
            this.book_cat.TextChanged += new System.EventHandler(this.book_cat_TextChanged);
            // 
            // book_price
            // 
            this.book_price.Location = new System.Drawing.Point(213, 125);
            this.book_price.Name = "book_price";
            this.book_price.Size = new System.Drawing.Size(153, 22);
            this.book_price.TabIndex = 3;
            this.book_price.TextChanged += new System.EventHandler(this.book_price_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(395, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // author_birth
            // 
            this.author_birth.Location = new System.Drawing.Point(213, 357);
            this.author_birth.Name = "author_birth";
            this.author_birth.Size = new System.Drawing.Size(153, 22);
            this.author_birth.TabIndex = 6;
            this.author_birth.TextChanged += new System.EventHandler(this.author_birth_TextChanged);
            // 
            // author_nat
            // 
            this.author_nat.Location = new System.Drawing.Point(213, 304);
            this.author_nat.Name = "author_nat";
            this.author_nat.Size = new System.Drawing.Size(153, 22);
            this.author_nat.TabIndex = 7;
            this.author_nat.TextChanged += new System.EventHandler(this.author_nat_TextChanged);
            // 
            // author_name
            // 
            this.author_name.Location = new System.Drawing.Point(213, 253);
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(153, 22);
            this.author_name.TabIndex = 8;
            this.author_name.TextChanged += new System.EventHandler(this.author_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(17, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Book name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(3, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Author birth day : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(3, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Author nationality : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RosyBrown;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(19, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Author name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RosyBrown;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(17, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Num of book : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(3, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Book category : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.RosyBrown;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(17, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Book price : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.RosyBrown;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(208, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Add Book..";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // add_book_u_s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IS_project.Properties.Resources.photo_14;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.author_name);
            this.Controls.Add(this.author_nat);
            this.Controls.Add(this.author_birth);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.book_price);
            this.Controls.Add(this.book_cat);
            this.Controls.Add(this.book_name);
            this.Name = "add_book_u_s";
            this.Size = new System.Drawing.Size(546, 445);
            this.Load += new System.EventHandler(this.add_book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox book_name;
        private System.Windows.Forms.TextBox book_cat;
        private System.Windows.Forms.TextBox book_price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox author_birth;
        private System.Windows.Forms.TextBox author_nat;
        private System.Windows.Forms.TextBox author_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
