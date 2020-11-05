using GroupProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject.GUI
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            DAL_Account acc = new DAL_Account();
            if (acc.CheckLogin(txt_Username.Text, txt_Password.Text))
                MessageBox.Show("True");
            else
                MessageBox.Show("False");
        }

        // note: kiểm tra nhập dữ liệu trên text box 
    }
}
