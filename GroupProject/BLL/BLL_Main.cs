using GroupProject.DAL;
using GroupProject.GUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject.BLL
{
    class BLL_Main
    {
        frm_Main f_Main;
        DAL_Goods goods = new DAL_Goods();

        public BLL_Main( frm_Main _f_Main)
        {
            f_Main = _f_Main;
        }

        public void Form_Load(object sender, EventArgs e)
        {
            ArrayList message_List = new System.Collections.ArrayList();
            message_List.Add("duc");
            message_List.Add("Hoang");
            f_Main.listbox_Message.DataSource = message_List;

        }

        public void Form_Closing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
