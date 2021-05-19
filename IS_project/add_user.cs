using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IS_project
{
    public partial class add_user : UserControl
    {
        private static add_user _add;
        public static add_user add
        {
            get
            {
                if (_add == null)
                    _add = new add_user();
                return _add;
            }
        }
        public add_user()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void add_user_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = -1;
            if(cash.Checked == true)
            {
                num = 1;
            }
            else if(credit.Checked == true)
            {
                num = 0;
            }
            else if(credit.Checked == true && cash.Checked == true)
            {
                num = -1;
            }

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("add_customer", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@check", num);
            com.Parameters.AddWithValue("@email", email.Text.Trim());
            com.Parameters.AddWithValue("@name", textBox1.Text);
            com.Parameters.AddWithValue("@adress", textBox2.Text);
            com.Parameters.AddWithValue("@phone", textBox3.Text);
            com.Parameters.AddWithValue("@pass", textBox4.Text);
            SqlParameter ruturnValue = com.Parameters.Add("@return", SqlDbType.Int);
            ruturnValue.Direction = ParameterDirection.ReturnValue;
            com.ExecuteReader();
            if (ruturnValue.Value.ToString() == "1" && num !=-1)
                MessageBox.Show("Data added");
            else if (ruturnValue.Value.ToString() == "0" && num ==-1)
                MessageBox.Show("Please inter all information");
            else
                MessageBox.Show("This user name exist enter other please");
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void credit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
