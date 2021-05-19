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
    public partial class big_user : UserControl
    {
        public big_user()
        {
            InitializeComponent();
            flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void User(string namee)
        {
            int counter = 0;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand(@"search1_auther ", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter mypar = com.Parameters.Add("@name", namee);

            SqlDataReader re1 = com.ExecuteReader();
            while (re1.Read())
            {
                counter++;
                small_user obj = new small_user();
                obj.obj_small_user((string)re1["Book_name"]
                    , (string)re1["Auther_name"]
                    , (string)re1["Auther_birth"]
                    , (string)re1["Book_category"]
                    , (string)re1["Auther_nationality"]
                    , (string)re1["Book_price"]);

                flowLayoutPanel1.Controls.Add(obj);

            }
            re1.Close();
            con.Close();
            //GroupBox user = new GroupBox();
            //user.Name = "user1";
            //user.BackColor = Color.Red;
            //Button menna = new Button();
            //user.Controls.Add(menna);
            //this.Controls.Add(user);
            if (counter == 0)
                MessageBox.Show("Auther is not found");

        }
        public void Search_by_book(string namee)
        {
            int counter = 0;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand(@"show1_books ", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("@name", namee));

            SqlDataReader re1 = com.ExecuteReader();
            while (re1.Read())
            {
                counter++;
                small_user obj = new small_user();
                obj.obj_small_user((string)re1["Book_name"]
                    , (string)re1["Auther_name"]
                    , (string)re1["Auther_birth"]
                    , (string)re1["Book_category"]
                    , (string)re1["Auther_nationality"]
                    , (string)re1["Book_price"]);
                flowLayoutPanel1.Controls.Add(obj);
            }
            re1.Close();
            con.Close();
            if (counter == 0)
                MessageBox.Show("Book is not found");
        }
        public void profile_fn()
        {
            profile_User_small obj = new profile_User_small();
            flowLayoutPanel1.Controls.Add(obj);
        }
        public void show_all_books()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");

            con.Open();
            SqlCommand com = new SqlCommand(@"show_all_books ", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataReader re1 = com.ExecuteReader();
            while (re1.Read())
            {

                small_user obj = new small_user();
                obj.obj_small_user((string)re1["Book_name"]
                    , (string)re1["Auther_name"]
                    , (string)re1["Auther_birth"]
                    , (string)re1["Book_category"]
                    , (string)re1["Auther_nationality"]
                    , (string)re1["Book_price"]);

                flowLayoutPanel1.Controls.Add(obj);

            }
            re1.Close();
            con.Close();
        }

        private void big_user_Load(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void big_user_Load_1(object sender, EventArgs e)
        {

        }
    }
}
