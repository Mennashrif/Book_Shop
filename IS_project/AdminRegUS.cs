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
    public partial class AdminRegUS : UserControl
    {
        private static AdminRegUS _admin_reg;
        public static AdminRegUS adminReg
        {
            get
            {
                if (_admin_reg == null)
                {
                    _admin_reg = new AdminRegUS();
                }
                return _admin_reg;

            }
        }

        public AdminRegUS()
        {
            InitializeComponent();
        }

        private void admin_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
          admin.regestration(admin_name.Text, admin_pass.Text, admin_phone.Text, admin_address.Text, security_num.Text);
        }

        private void admin_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void security_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminRegUS_Load(object sender, EventArgs e)
        {

        }
    }
}
