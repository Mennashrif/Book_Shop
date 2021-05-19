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
    public partial class add_book_u_s : UserControl
    {
        private static add_book_u_s _add_book;
        public static add_book_u_s AddBook
        {
            get
            {
                if (_add_book == null)
                {
                    _add_book = new add_book_u_s();
                }
             return _add_book;
                
            }
        }

        public add_book_u_s()
        {
            InitializeComponent();
            label8.BackColor = System.Drawing.Color.Transparent;
        }

        private void add_book_Load(object sender, EventArgs e)
        {

        }

        private void book_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void book_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void book_cat_TextChanged(object sender, EventArgs e)
        {

        }
         SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("add_book", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add(new SqlParameter("@book_name", book_name.Text.Trim()));
            com.Parameters.Add(new SqlParameter("@book_price", book_price.Text.Trim()));
            com.Parameters.Add(new SqlParameter("@book_cat", book_cat.Text.Trim()));
            com.Parameters.Add(new SqlParameter("@num_of_Book", textBox1.Text.Trim()));
            com.Parameters.Add(new SqlParameter("@author_name", author_name.Text.Trim()));
            com.Parameters.Add(new SqlParameter("@author_nat", author_nat.Text.Trim()));
            com.Parameters.Add(new SqlParameter("@author_birth", author_birth.Text.Trim()));


            SqlParameter parmater = com.Parameters.Add("@return", SqlDbType.Int);
            parmater.Direction = ParameterDirection.ReturnValue;

            com.ExecuteReader();
            if (parmater.Value.ToString() == "-1")
            {
                MessageBox.Show("Enter all informaion");
            }
            else if (parmater.Value.ToString() == "0")
            {
                MessageBox.Show("Inserted sucsessfully *-*");
            }

            con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void author_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void author_nat_TextChanged(object sender, EventArgs e)
        {

        }

        private void author_birth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
