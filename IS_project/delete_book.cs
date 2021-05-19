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
    public partial class delete_book : UserControl
    {
        private static delete_book _delbook;
        public static delete_book delbook
        {
            get
            {
                if (_delbook == null)
                    _delbook = new delete_book();
                return _delbook;
            }

        }
        public delete_book()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void delete_book_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("Delet_book", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@book_name", textBox1.Text);
            SqlParameter ruturnValue = com.Parameters.Add("@return", SqlDbType.Int);
            ruturnValue.Direction = ParameterDirection.ReturnValue;
            com.ExecuteReader();
            if (ruturnValue.Value.ToString() == "1")
            {
                MessageBox.Show("Book deleted");
            }
            else
                MessageBox.Show("Not exists");
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
