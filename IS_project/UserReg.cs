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
    public partial class UserReg : UserControl
    {

            private static UserReg _user_reg;
            public static UserReg userReg
            {
                get
                {
                    if (_user_reg == null)
                    {
                    _user_reg = new UserReg();
                    }
                    return _user_reg;

                }
            }
         public UserReg()
        {
            InitializeComponent();
        }

        private void UserReg_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        { int check = -1;
            
                
            if(cash.Checked==true)
            {
                check = 1;
            }
            else if(credit.Checked==true)
            {
                check = 0;
            }
            
            HelperUser.myuser.user_regestration(check,email.Text.Trim(),textBox3.Text.Trim(), textBox2.Text.Trim(), textBox1.Text.Trim(),
                textBox4.Text.Trim());

            //con.Open();
            //SqlCommand com = new SqlCommand("regestration", con);
            //com.CommandType = CommandType.StoredProcedure;

            //com.Parameters.Add(new SqlParameter("@username", textBox3.Text));
            //com.Parameters.Add(new SqlParameter("@password", textBox2.Text));
            //com.Parameters.Add(new SqlParameter("@user_phone", textBox1.Text));
            //com.Parameters.Add(new SqlParameter("@user_address", textBox4.Text));


            //SqlParameter parmater = com.Parameters.Add("@return", SqlDbType.Int);
            //parmater.Direction = ParameterDirection.ReturnValue;

            //com.ExecuteReader();
            //if (parmater.Value.ToString() == "1")
            //{
            //    MessageBox.Show("Enter all informaion");
            //}
            //else if (parmater.Value.ToString() == "0")
            //{
            //    MessageBox.Show("Inserted sucsessfully *-*");
            //}
            //else if (parmater.Value.ToString() == "2")
            //{
            //    MessageBox.Show("Already exists!");
            //}


            //con.Close();

        }

        private void user_name_Click(object sender, EventArgs e)
        {

        }

        private void user_pass_Click(object sender, EventArgs e)
        {

        }

        private void user_phone_Click(object sender, EventArgs e)
        {

        }

        private void user_add_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void cash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void credit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
