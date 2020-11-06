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
using GroupProject.BLL;

namespace GroupProject.GUI
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            BLL_Login bll_Login =   new BLL_Login(this);
            btn_Login.Click += new EventHandler(bll_Login.Btn_Click);
            btn_Exit.Click += new EventHandler(bll_Login.Btn_Click);
        }

    }
}
