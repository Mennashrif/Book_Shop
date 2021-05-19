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
    public partial class user_main_page : Form
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
        public user_main_page()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            label3.BackColor = System.Drawing.Color.Transparent;
        }
        private void user_main_page_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in big_user1.Controls)
            {
                c.Controls.Clear();

            }
            big_user3.Visible = false;
            big_user2.Visible = false;
            big_user4.Visible = false;
            big_user1.User(textBox1.Text);
            big_user1.Visible = true;


        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control c in big_user1.Controls)
            {
                c.Controls.Clear();

            }

            big_user1.Visible = false;
            big_user2.Visible = false;
            big_user4.Visible = false;
            big_user3.Search_by_book(textBox2.Text.Trim());
            big_user3.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            big_user1.Visible = false;
            big_user2.Visible = false;
            big_user3.Visible = false;
            big_user4.show_all_books();
            big_user4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            big_user3.Visible = false;
            big_user1.Visible = false;
            big_user4.Visible = false;
            big_user2.profile_fn();
            big_user2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
              
          //  Application.Exit();

            Form1 form = new Form1();
            //form.Show();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void big_user4_Load(object sender, EventArgs e)
        {

        }
    }
    }

