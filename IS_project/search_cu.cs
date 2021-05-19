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
    public partial class search_cu : UserControl
    {
        private static search_cu _search;
        public static search_cu search
        {
            get
            {
                if (_search == null)
                    _search = new search_cu();
                return _search;
            }

        }
        public search_cu()
        {
            InitializeComponent();
            flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            search2 menna1 = new search2();
            string name = null, adress = null, phone = null, passward = null;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("search_customers", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@name", textBox1.Text);
            SqlDataReader rdr = com.ExecuteReader();
            while (rdr.Read())
            {
                name = (string)rdr["User_name"];
                adress = (string)rdr["User_adress"];
                phone = (string)rdr["User_phone"];
                passward = (string)rdr["User_pass"];
            }
            if (name != null)
            {


                menna1.menna(textBox1.Text);
                flowLayoutPanel1.Controls.Add(menna1);


            }
            else
                MessageBox.Show("name is wrong");
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_cu_Load(object sender, EventArgs e)
        {

        }
    }
}
