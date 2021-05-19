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
    public partial class search2 : UserControl
    {
        public search2()
        {
            InitializeComponent();
        }

        private void search2_Load(object sender, EventArgs e)
        {

        }
        public void menna(string textbox)
        {
            string name = null, adress = null, phone = null, passward = null,email=null,pay=null;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("search_customers", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@name", textbox);
            SqlDataReader rdr = com.ExecuteReader();
            while (rdr.Read())
            {
                name = (string)rdr["User_name"];
                adress = (string)rdr["User_adress"];
                phone = (string)rdr["User_phone"];
                passward = (string)rdr["User_pass"];
                email = (string)rdr["User_email"];
                pay = (string)rdr["way_of_payment"];
            }
            if (name != null)
            {
                label5.Text = name;
                label6.Text = adress;
                label7.Text = phone;
                label8.Text = passward;
                email1.Text = email;
                way1.Text = pay;
                /* Label[] l1 = new Label[4];
                 l1[0] = new Label();
                 l1[1] = new Label();
                 l1[2] = new Label();
                 l1[3] = new Label();

                 l1[0].Text = "name : " + name + "/n";
                 l1[0].Text = "adress : " + adress;

                 this.Controls.Add(l1[0]);

                // _search.Controls.Add(l1[1]);
                 //_search.Controls.Add(l3);
                 //_search.Controls.Add(l4);*/


            }
            else
                MessageBox.Show("name is wrong");
            con.Close();
        }
    }
}
