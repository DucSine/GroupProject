using GroupProject.BLL;
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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            BLL_Main bll_Main = new BLL_Main(this);
            InitializeComponent();
            this.Load += new EventHandler(bll_Main.Form_Load);
            this.FormClosing += new FormClosingEventHandler(bll_Main.Form_Closing);
            gv_Goods.CellClick += new DataGridViewCellEventHandler(bll_Main.gv_Goods_CellClick);

        }
    }
}
