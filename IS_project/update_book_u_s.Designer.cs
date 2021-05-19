namespace IS_project
{
    partial class update_book_u_s
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
            this.pbookName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bookCat = new System.Windows.Forms.TextBox();
            this.bookPrice = new System.Windows.Forms.TextBox();
            this.bookName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbookName
            // 
            this.pbookName.Location = new System.Drawing.Point(299, 109);
            this.pbookName.Name = "pbookName";
            this.pbookName.Size = new System.Drawing.Size(139, 22);
            this.pbookName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(245, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookCat
            // 
            this.bookCat.Location = new System.Drawing.Point(299, 255);
            this.bookCat.Name = "bookCat";
            this.bookCat.Size = new System.Drawing.Size(139, 22);
            this.bookCat.TabIndex = 2;
            // 
            // bookPrice
            // 
            this.bookPrice.Location = new System.Drawing.Point(299, 203);
            this.bookPrice.Name = "bookPrice";
            this.bookPrice.Size = new System.Drawing.Size(139, 22);
            this.bookPrice.TabIndex = 3;
            // 
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(299, 162);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(139, 22);
            this.bookName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RosyBrown;
            this.label5.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(42, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 30);
            this.label5.TabIndex = 22;
            this.label5.Text = "New book name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RosyBrown;
            this.label4.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(42, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 30);
            this.label4.TabIndex = 21;
            this.label4.Text = "New book price :  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "New book category : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(42, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "Current name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(202, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Update book..";
            // 
            // update_book_u_s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IS_project.Properties.Resources.photo_14;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.bookPrice);
            this.Controls.Add(this.bookCat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbookName);
            this.Name = "update_book_u_s";
            this.Size = new System.Drawing.Size(606, 406);
            this.Load += new System.EventHandler(this.update_book_u_s_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pbookName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bookCat;
        private System.Windows.Forms.TextBox bookPrice;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
