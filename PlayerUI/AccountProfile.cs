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
    public partial class AccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount);}
        }
        public AccountProfile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        void ChangeAccount(Account acc)
        {
            txt_User.Text = LoginAccount.UserName;
            txt_Name.Text = LoginAccount.DisplayName;
        }

        void UpdateAccountInfo()
        {
            string displayName = txt_Name.Text;
            string password = txt_Password.Text;
            string newpass = txt_NewPassword.Text;
            string reenterPass = txt_RetypePassword.Text;
            string userName = txt_User.Text;

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Mật khẩu đặt lại không khớp với nhau!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpass))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khấu!");
                }
            }
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        public class AccountEvent : EventArgs
        {
            private Account acc;

            public Account Acc
            {
                get { return acc; }
                set { acc = value; }
            }

            public AccountEvent(Account acc)
            {
                this.Acc = acc;
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private void btnEexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
