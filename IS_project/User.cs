using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_project
{
   public class User
    {
        public string user_name, user_pass, user_addess, user_phone,wayOfpay,user_email;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VKVAVA1\SQLEXPRESS;Initial Catalog=project_is;Integrated Security=True");

        public User()
        {
            user_name = "empty";
            user_pass = "empty";
            user_addess = "empty";
            user_phone = "empty";
        }

        public void user_regestration(int num,string email,string name,string pass,string phone,string address)
        {

            con.Open();

            SqlCommand com = new SqlCommand("regestration", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("@check", num));
            com.Parameters.Add(new SqlParameter("@user_email", email));
            com.Parameters.Add(new SqlParameter("@username", name));
            com.Parameters.Add(new SqlParameter("@password", pass));
            com.Parameters.Add(new SqlParameter("@user_phone", phone));
            com.Parameters.Add(new SqlParameter("@user_address", address));


            SqlParameter parmater = com.Parameters.Add("@return", SqlDbType.Int);
            parmater.Direction = ParameterDirection.ReturnValue;

            com.ExecuteReader();
            if (parmater.Value.ToString() == "1" && num == -1)
            {
                MessageBox.Show("Enter all informaion");
            }
            else if (parmater.Value.ToString() == "0")
            {
                MessageBox.Show("Inserted sucsessfully *-*");
            }
            else if (parmater.Value.ToString() == "2")
            {
                MessageBox.Show("Already exists!");
            }


            con.Close();

        }
        public bool user_login(string namel,string passl)
        {
            string name_="", pass_="", addrss_="", phone_="",way="",email="";
            con.Open();
            SqlCommand command = new SqlCommand("select * from user_login('" + namel+ "'" + "," + "'" +
                passl + "')"
                , con);

            SqlDataReader rdr = command.ExecuteReader();

            int val = -1, c = 0;
            while (rdr.Read())
            {

                val = (int)rdr["id"];
                if (val == -1)
                {
                    MessageBox.Show("Incorrect info");
                    c++;
                    break;
                }
                name_ = (string)rdr["u_name"];
                pass_ = (string)rdr["pass"];
                phone_ = (string)rdr["phone"];
                addrss_ = (string)rdr["addr"];
                email = (string)rdr["email"];
                way = (string)rdr["payment"];


            }

            if (c == 0)
            {
                user_name = name_;
                user_pass = pass_;
                user_phone = phone_;
                user_addess = addrss_;
                user_email = email;
                wayOfpay = way;
                con.Close();
                return true;
            }
           
            rdr.Close();
            con.Close();
            return false;

        }


    }
}
