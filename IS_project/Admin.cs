using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IS_project
{
  public  class Admin
    {
         
        public string admin_name, admin_pass, admin_phone, admin_address;

        public Admin()
        {
            admin_name = "empty";
            admin_pass = "empty";
            admin_phone = "empty";
            admin_address = "empty";
        }


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");

        public void regestration(string a_rname, string a_r_pass, string a_r_phone, string a_r_address,string security_num)
        {

            con.Open();
            if (security_num!= "admin2018")
            {
               
                MessageBox.Show("Invalied security number ");
                return;
            }
            SqlCommand com = new SqlCommand("add_admin", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add(new SqlParameter("@adminname", a_rname));
            com.Parameters.Add(new SqlParameter("@adminPass", a_r_pass));
            com.Parameters.Add(new SqlParameter("@admin_phone", a_r_phone));
            com.Parameters.Add(new SqlParameter("@admin_address", a_r_address));


            SqlParameter parmater = com.Parameters.Add("@return_admin", SqlDbType.Int);
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
            else if (parmater.Value.ToString() == "-2")
            {
                MessageBox.Show("Already exists , choose another name !");
            }


            con.Close();
        }
        
        public bool admin_login(string Admin_name,string Admin_pass)
        {
            con.Open();
            SqlCommand command = new SqlCommand("select * from admin_login('" + Admin_name + "'" + "," + "'" +
                Admin_pass + "')"
                , con);

            SqlDataReader rdr = command.ExecuteReader();
            int val = -1, c = 0; string name = "", pass = "", phone = "", addrss = "";
            while (rdr.Read())
            {

                val = (int)rdr["admin_id"];
                if (val == -1)
                {
                    MessageBox.Show("Incorrect info");
                    c++;
                    break;
                }
                name = (string)rdr["admin_name"];
                pass = (string)rdr["admin_pass"];
                phone = (string)rdr["admin_phone"];
                addrss = (string)rdr["admin_addr"];

            }

            if (c == 0)
            {
                admin_name = name;
                admin_pass = pass;
                admin_phone = phone;
                admin_address = addrss;
       //         MessageBox.Show(admin_name + " " + admin_pass);
                rdr.Close();
                con.Close();
               
                return true;
            }
            con.Close();
            return false;
        }

        public void add_book(string bookName,double bookPrice , string bookPhone,string authorName)
        {

            con.Open();
            SqlCommand com = new SqlCommand("add_book", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add(new SqlParameter("@book_name", bookName));
            com.Parameters.Add(new SqlParameter("@book_price", bookPrice));
            com.Parameters.Add(new SqlParameter("@book_cat", bookPhone));
            com.Parameters.Add(new SqlParameter("@author_name", authorName));


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

    }
}
