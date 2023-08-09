using QuanLyBanBida;
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
using static QuanLyBanBida.AccountProfile;

namespace QuanLyBanBida
{
    public partial class Form1 : Form
    {
        private Account loginAccount;
        public Account LoginAccount 
        {
               get { return loginAccount; } 
               set { loginAccount = value; 
               ChangeAccount(loginAccount.Type); } 
        }

        public Form1(Account acc) 
        {
            InitializeComponent();
            this.LoginAccount = acc;
            hideSubMenu();
        }

        void ChangeAccount(int type) 
        {
            btn_Admin.Enabled = type == 1;
        }
        private void hideSubMenu()
        {
            panelAdmin.Visible = false;
            panelAccount.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new f_AdminBill());
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAdmin);
        }


        private void btn_Table_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminTable());//..
            //your codes
            //..
            hideSubMenu();
        }


        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAccount);
        }
        #region ToolsSubMenu
        private void btn_Account_Click(object sender, EventArgs e)
        {
            openChildForm(new AccountProfile(LoginAccount));
            hideSubMenu();
        }
        void f_UpdateAccount(object sender, AccountEvent e)
        {
            btn_Account.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }
        #endregion


        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new Chatbot());
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dangxuat = MessageBox.Show("bạn có muốn dăng xuất không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dangxuat == DialogResult.Yes)
            {
                Login f = new Login();
                f.Show();
                this.Hide();
            }            
        }

        private Form activeForm = null;

        

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            openChildForm(new f_TableManager());
            hideSubMenu();
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            openChildForm(new f_AdminBill());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btn_ThucAn_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminFood());
            //your codes
            //..
            hideSubMenu();
        }

        private void btn_acc_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminAccount());
            //your codes
            //..
            hideSubMenu();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openChildForm(new AdminCustom());
            //your codes
            //..
            hideSubMenu();
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminCategory());
            hideSubMenu();
        }
    }
}
