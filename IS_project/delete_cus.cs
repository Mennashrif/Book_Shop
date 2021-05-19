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
    public partial class delete_cus : UserControl
    {
        private static delete_cus _del;
        public static delete_cus del
        {
            get
            {
                if (_del == null)
                    _del = new delete_cus();
                return _del;
            }

        }
        public delete_cus()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("delete_customers", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@name", textBox1.Text);
            SqlParameter ruturnValue = com.Parameters.Add("@value", SqlDbType.Int);
            ruturnValue.Direction = ParameterDirection.ReturnValue;
            com.ExecuteReader();
            if (ruturnValue.Value.ToString() == "1")
                MessageBox.Show("user deleted");
            else
                MessageBox.Show("Enter correct username");
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_cus_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
