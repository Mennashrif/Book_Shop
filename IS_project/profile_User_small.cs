using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_project
{
    public partial class profile_User_small : UserControl
    {
        public profile_User_small()
        {
            InitializeComponent();
           label2.Text = HelperUser.myuser.user_name;
           label6.Text = HelperUser.myuser.user_phone;
           label3.Text = HelperUser.myuser.user_addess;
           email.Text = HelperUser.myuser.user_email;
            pay.Text = HelperUser.myuser.wayOfpay;


        }

        private void profile_User_small_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void pay_Click(object sender, EventArgs e)
        {

        }
    }
}
