using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace IS_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");
        private void login_b_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("select * from user_login('" + user_log_text.Text.Trim() + "'" + "," + "'" +
                pass_text.Text.Trim() + "')"
                , con);
            
            SqlDataReader rdr = command.ExecuteReader();

            int val=-1,c=0; string name="";
            while (rdr.Read())
            {
               
               val = (int)rdr["id"];
                if(val==-1)
                {
                    MessageBox.Show("Incorrect info");
                    c++;
                    break;
                }
               name = (string)rdr["u_name"];
                
            }
            
            if (c==0)
            {
                MessageBox.Show("Hi " + name);
            }

            rdr.Close();
            con.Close();


            //string name = (string)rdr["User_name"] ;
            /* SqlDataAdapter SDA = new SqlDataAdapter(query, con);
             DataTable dtbl = new DataTable();
             SDA.Fill(dtbl);
             if (dtbl.Rows.Count==1)
             {
                 MessageBox.Show("login successfuly");
                 con.Close();
             }
             else 
             {
                 MessageBox.Show("Not valied");
                 con.Close();
             }*/

        }

        private void user_log_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
