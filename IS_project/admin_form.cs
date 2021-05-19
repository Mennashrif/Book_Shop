using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_project
{
    public partial class admin_form : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );

        public admin_form()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            hello_lable.Text = "Welcome "+helper.admin.admin_name;   
        }

        private void admin_form_Load(object sender, EventArgs e)
        {

        }
 

        private void admin_lable_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_book_Click(object sender, EventArgs e)
        {
            if(!add_book_p.Controls.Contains(add_book_u_s.AddBook))
            {
                add_book_p.Controls.Add(add_book_u_s.AddBook);
                add_book_u_s.AddBook.Dock = DockStyle.Fill;
                add_book_u_s.AddBook.BringToFront();
            }
            else
            {
                add_book_u_s.AddBook.BringToFront();
            }
        }

        private void add_book_p_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!add_book_p.Controls.Contains(update_book_u_s.uadateBook))
            {
                add_book_p.Controls.Add(update_book_u_s.uadateBook);
                update_book_u_s.uadateBook.Dock = DockStyle.Fill;
                update_book_u_s.uadateBook.BringToFront();
            }
            else
            {
                update_book_u_s.uadateBook.BringToFront();
            }
        }

        private void hello_lable_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!add_book_p.Controls.Contains(delete_cus.del))
            {
                add_book_p.Controls.Add(delete_cus.del);
                delete_cus.del.Dock = DockStyle.Fill;
                delete_cus.del.BringToFront();
            }
            else
                delete_cus.del.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!add_book_p.Controls.Contains(delete_book.delbook))
            {
                add_book_p.Controls.Add(delete_book.delbook);
                delete_book.delbook.Dock = DockStyle.Fill;
                delete_book.delbook.BringToFront();
            }
            else
                delete_book.delbook.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!add_book_p.Controls.Contains(add_user.add))
            {
                add_book_p.Controls.Add(add_user.add);
                add_user.add.Dock = DockStyle.Fill;
                add_user.add.BringToFront();
            }
            else
                add_user.add.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!add_book_p.Controls.Contains(update_user.upuser))
            {
                add_book_p.Controls.Add(update_user.upuser);
                update_user.upuser.Dock = DockStyle.Fill;
                update_user.upuser.BringToFront();
            }
            else
                update_user.upuser.BringToFront();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!add_book_p.Controls.Contains(search_cu.search))
            {
                add_book_p.Controls.Add(search_cu.search);
                search_cu.search.Dock = DockStyle.Fill;
                search_cu.search.BringToFront();
            }
            else
                search_cu.search.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            // form.Show();
            this.Close();
        }


    }
}
