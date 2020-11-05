using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GroupProject.BLL
{
    class BLL_Login
    {
        //tao ra mot doi tuong tu DAL(Data access layer)
        DAL.DAL_Account dal_account = new DAL.DAL_Account();

        //tao ra mot doi tuong tu GUI
         GUI.frm_Login login;

         public BLL_Login(GUI.frm_Login l)
        {
            login = l;
        }

        //Tao ra mot ham kem tra dang nhap
         public void CheckLogin()
         {
             
             bool value = dal_account.CheckLogin(login.txt_Username.Text, login.txt_Password.Text);

             if (value == true)
             {
                 
                //goi toi ham main
                 GUI.frm_Main main = new GUI.frm_Main();

                 //an frm_dangnhap
                 login.Hide();
                 main.ShowDialog();

                 //sau khi tat ham main hien thi frm_dangnhap
                 login.Show();
                
             }
             else {
                 MessageBox.Show("Login failed");
             }
                
         }

       

    }
}
