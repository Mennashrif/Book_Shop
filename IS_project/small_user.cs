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
    public partial class small_user : UserControl
    {
        public small_user()
        {
            InitializeComponent();
        }

        private void small_user_Load(object sender, EventArgs e)
        {

        }
        public void obj_small_user(string name, string name1, string name2, string name3, string name4, string name5)
        {
            label13.Text = name;
            label1.Text = name1;
            label10.Text = name2;
            label6.Text = name3;
            label8.Text = name4;
            label3.Text = name5;
            if(HelperUser.myuser.wayOfpay=="cash" || HelperUser.myuser.wayOfpay == "Cash")
            {
                textBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand(@"order_book ", con);
            com.CommandType = CommandType.StoredProcedure;

            if ((textBox1.Text == "" || textBox1.Text.Length < 12 || textBox1.Text == "Serial number")
                && HelperUser.myuser.wayOfpay=="credit" ||  HelperUser.myuser.wayOfpay == "Credit")
            {
                MessageBox.Show("invalied serial number");
                return;
            }
            SqlParameter mypar1 = com.Parameters.Add("@name_of_book", button1.Text);

            // SqlParameter mypar2 = com.Parameters.Add("@name_of_user", "menna");
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("order is done ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
