using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class DangNhap : Form
    {
        
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            var userBLL = new UserBLL();

            if (userBLL.Login(username, password))
            {
                MessageBox.Show("Đăng Nhập Thành Công!");
            }
            else
            {
                MessageBox.Show("Tên Đăng Nhập hoặc Password không đúng!");
            }    
        }
    }
}
