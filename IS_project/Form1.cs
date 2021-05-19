using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace IS_project
{
    public partial class Form1 : Form
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
       
        public Form1()
        {
            InitializeComponent();
            label4.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            panel1.BackColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Minimized;
            //this.Close();
            //th = new Thread(OpenNewForm);
            //th.SetApartmentState(ApartmentState.STA);
            //th.Start();
            //regestration_login reg = new regestration_login();
            //reg.Show();
            if (!panel1.Controls.Contains(UserReg.userReg))
            {
                panel1.Controls.Add(UserReg.userReg);
                UserReg.userReg.Dock = DockStyle.Fill;
                UserReg.userReg.BringToFront();
            }
            else
            {
                UserReg.userReg.BringToFront();
            }
        }


        private void admin_option_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            //// Admin admin = new Admin(admin_name.Text, admin_pass.Text, admin_phone.Text, admin_address.Text);
            //Admin admin = new Admin();
            //admin.regestration(admin_name.Text, admin_pass.Text, admin_phone.Text, admin_address.Text, security_num.Text);
            if (!panel1.Controls.Contains(AdminRegUS.adminReg))
            {
                panel1.Controls.Add(AdminRegUS.adminReg);
                AdminRegUS.adminReg.Dock = DockStyle.Fill;
                AdminRegUS.adminReg.BringToFront();
            }
            else
            {
                AdminRegUS.adminReg.BringToFront();
            }

        }

        private void login_admin_Click(object sender, EventArgs e)
        {/* if (helper.admin.admin_login(admin_log_name.Text.Trim(), admin_log_pass.Text.Trim()))
            {
                MessageBox.Show(helper.admin.admin_name);*/
         //Admin admin = new Admin();

            if (helper.admin.admin_login(admin_log_name.Text.Trim(), admin_log_pass.Text.Trim()))
            {

                admin_form admin_form = new admin_form();
                admin_form.Show();
            }
            //helper.admin.admin_name = "maya";
            //MessageBox.Show(helper.admin.admin_name);
            //   admin_form admin_form = new admin_form();
            //    admin_form.Show();



            /*     con.Open();
                 SqlCommand command = new SqlCommand("select * from admin_login('" + admin_name + "'" + "," + "'" +
                     admin_pass + "')"
                     , con);

                 SqlDataReader rdr = command.ExecuteReader();
                 int val = 0, c = 0; string name = "", pass = "", phone = "", addrss = "";
                 while (rdr.Read())
                 {

                     val = (int)rdr["admin_id"];
                     if (val == -1)
                     {
                         MessageBox.Show("Incorrect info");
                         c++;
                         break;
                     }
                     name = (string)rdr["admin_name"];
                     pass = (string)rdr["admin_pass"];
                     phone = (string)rdr["admin_phone"];
                     addrss = (string)rdr["admin_addr"];

                 }

                 if (c == 0)
                 {
                     MessageBox.Show("Hi " + name);
                     rdr.Close();
                 }

                 con.Close();
                 */
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void use_log_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(User_log.userLog))
            {
                panel1.Controls.Add(User_log.userLog);
                User_log.userLog.Dock = DockStyle.Fill;
                User_log.userLog.BringToFront();
            }
            else
            {
                User_log.userLog.BringToFront();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
