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
    public partial class update_book_u_s : UserControl
    {
        private static update_book_u_s _update_book;
        public static update_book_u_s uadateBook
        {
            get
            {
                if (_update_book == null)
                {
                    _update_book = new update_book_u_s();
                }
                return _update_book;

            }
        }

        public update_book_u_s()
        {
            InitializeComponent();
        }

        private void update_book_u_s_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("update_book", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add(new SqlParameter("@pbook_name", pbookName.Text.Trim()));
            com.Parameters.Add(new SqlParameter("@book_name", bookName.Text.Trim()));
            if (bookPrice.Text=="")
            {
                bookPrice.Text= "0";
                com.Parameters.Add(new SqlParameter("@book_price",bookPrice.Text.Trim()));
            }
            else
            {
                com.Parameters.Add(new SqlParameter("@book_price", bookPrice.Text.Trim()));
            }
            com.Parameters.Add(new SqlParameter("@book_cat", bookCat.Text.Trim()));


            SqlParameter parmater = com.Parameters.Add("@return", SqlDbType.Int);
            parmater.Direction = ParameterDirection.ReturnValue;

            com.ExecuteReader();
            if (parmater.Value.ToString() == "-2")
            {
                MessageBox.Show("Try again");
            }
            else if (parmater.Value.ToString() == "0")
            {
                MessageBox.Show("Updated sucsessfully *-*");
            }

            con.Close();
        }
    }
}
