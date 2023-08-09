using QuanLyBanBida.DAO;
using QuanLyBanBida.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanBida
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        #region Methods
        bool Login1(string username, string password) 
        {
            return AccountDAO.Instance.Login(username, password); 
        }
        #endregion

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userName = txt_NameID.Text; 
            string passWord = txt_Password.Text;
            if (Login1(userName, passWord)) 
            {
                 Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName); 
                 Form1 f = new Form1(loginAccount); 
                 this.Hide();
                 f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        private void btn_ResetPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword f = new ForgotPassword();
            f.ShowDialog(this);
        }
    }
}
