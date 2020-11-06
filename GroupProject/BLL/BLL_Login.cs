﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroupProject.DAL;
using GroupProject.GUI;

namespace GroupProject.BLL
{
    
    class BLL_Login :Form
    {
        frm_Login log;
        DAL_Account acc = new DAL_Account();
        int cout = 0;

        public BLL_Login(GUI.frm_Login l)
        {
            log = l;
        }
        
        public void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            switch (btn.Name)
            {
                case "btn_Login":
                    if (acc.CheckLogin(log.txt_Username.Text, log.txt_Password.Text))
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new frm_Main().Show();
                        log.Visible = false;
                    }
                    else
                    {
                        cout++;
                        string message = string.Format("Đăng nhập thất bại lần {0}", cout);
                        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (cout == 5)
                        {
                            MessageBox.Show("Đăng nhập thất bại quá 5 lần, thoát", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                    }                        
                    break;
                case "btn_Exit":
                    DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                        Application.Exit();
                    break;
            }

            

            
        }
    }
}
