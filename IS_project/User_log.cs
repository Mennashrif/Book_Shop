using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IS_project
{
    public partial class User_log : UserControl
    {

        private static User_log _user_log;
        public static User_log userLog
        {
            get
            {
                if (_user_log == null)
                {
                    _user_log = new User_log();
                }
                return _user_log;

            }
        }
        public User_log()
        {
            InitializeComponent();
            

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");

        private void login_b_Click(object sender, EventArgs e)
        {
           if( HelperUser.myuser.user_login(user_log_text.Text.Trim(), pass_text.Text.Trim()))
            {
                //Form1 form = new Form1();
                //form.Close();
                //MessageBox.Show("a7a");
                user_main_page user = new user_main_page();
                user.Show();



            }
            //con.Open();
            //SqlCommand command = new SqlCommand("select * from user_login('" + user_log_text.Text.Trim() + "'" + "," + "'" +
            //    pass_text.Text.Trim() + "')"
            //    , con);
            //SqlDataReader rdr = command.ExecuteReader();

            //int val = -1, c = 0; string name = "";
            //while (rdr.Read())
            //{

            //    val = (int)rdr["id"];
            //    if (val == -1)
            //    {
            //        MessageBox.Show("Incorrect info");
            //        c++;
            //        break;
            //    }
            //    name = (string)rdr["u_name"];

            //}

            //if (c == 0)
            //{
            //    MessageBox.Show("Hi " + name);
            //}

            //rdr.Close();
            //con.Close();
        }

        private void User_log_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
