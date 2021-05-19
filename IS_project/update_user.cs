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
    public partial class update_user : UserControl
    {

            private static update_user _upuser;
            public static update_user upuser
            {
                get
                {
                    if (_upuser == null)
                        _upuser = new update_user();
                    return _upuser;
                }
            }
        public update_user()
        {

            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("update_customers", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@num", textBox1.Text);
            com.Parameters.AddWithValue("@name", textBox2.Text);
            com.Parameters.AddWithValue("@change", textBox3.Text);
            SqlParameter ruturnValue = com.Parameters.Add("@return", SqlDbType.Int);
            ruturnValue.Direction = ParameterDirection.ReturnValue;
            com.ExecuteReader();
            if (ruturnValue.Value.ToString() == "1")
                MessageBox.Show("Data updated");
            else if (ruturnValue.Value.ToString() == "0")
                MessageBox.Show("user name is wrong");
            else if (ruturnValue.Value.ToString() == "-1")
                MessageBox.Show("This new user name exist enter other please");
            else
                MessageBox.Show("Please enter correct number");
            con.Close();
        }

        private void update_user_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
