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
using System.Threading;

namespace IS_project
{
    public partial class regestration_login : Form
    {
        public regestration_login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");

        private void user_name_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand com = new SqlCommand("regestration",con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add(new SqlParameter("@username", textBox3.Text));
            com.Parameters.Add(new SqlParameter("@password", textBox2.Text));
            com.Parameters.Add(new SqlParameter("@user_phone", textBox1.Text));
            com.Parameters.Add(new SqlParameter("@user_address", textBox4.Text));

           
            SqlParameter parmater = com.Parameters.Add("@return", SqlDbType.Int); 
            parmater.Direction = ParameterDirection.ReturnValue;
          
            com.ExecuteReader();
            if(parmater.Value.ToString() =="1")
            {
                MessageBox.Show("Enter all informaion");
            }
            else if(parmater.Value.ToString()=="0")
            {
                MessageBox.Show("Inserted sucsessfully *-*");
            }
            else if(parmater.Value.ToString()=="2")
            {
                MessageBox.Show("Already exists!");     
            }

          
            con.Close();

            
            /* if(val<0)
             {
                 MessageBox.Show("ERORR");
             }
             else
             {
                 MessageBox.Show("Tamm");
             }*/
            /*string query1 = "select * from [User] where User_name=" + "'" + textBox3.Text.Trim() + "'";

            SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
            DataTable dtbl = new DataTable();
            SDA1.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                con.Close();
                MessageBox.Show("This username is already exist");
                
            }
            else
            {
                String query = "INSERT INTO user_info (User_name,User_phone,User_adress,User_pass) VALUES('" + textBox3.Text + "','" +
                    textBox1.Text + "','" + textBox4.Text + "','" + textBox2.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("INSERTED SUCCESSFULLY!!!");
            }*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Thread th;

        private void login_b_Click(object sender, EventArgs e)
        {
            //this.Hide();
            /* Login log = new Login();
             log.Show();*/
            //this.Close();
            //th = new Thread(OpenNewForm);
            //th.SetApartmentState(ApartmentState.STA);
            //th.Start();
            regestration_login reg = new regestration_login();
            reg.Show();
        }

        //private void OpenNewForm()
        //{
        //    Application.Run(new Login());
        //}
    

        private void regestration_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason==CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
