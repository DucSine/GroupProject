using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroupProject.DAL;

namespace GroupProject.GUI
{
    public partial class frm_Login : Form
    {
        //tao ra mot doi tuong tu BL
        BLL.BLL_Login login;

        public frm_Login()
        {
            login = new BLL.BLL_Login(this);
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            login.CheckLogin();
        }
        
        

        // note: kiểm tra nhập dữ liệu trên text box 
    }
}
