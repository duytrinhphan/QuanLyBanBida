using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanBida
{
    public partial class AdminAccount : Form
    {
        private string connect = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanBiDaFinal1;Integrated Security=True";
        BindingSource bs = null;
        public AdminAccount()
        {
            InitializeComponent();
            viewlistaccount();
        }

        #region Methods
        public void viewlistaccount()
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "select DisplayName as[ Tên tài khoản ], UserName as[Tên người dùng], PassWord as[mật khẩu],Type as[Loại tài khoản] from Account ";
            SqlDataAdapter adpter = new SqlDataAdapter(query, sqlConnection);
            DataSet dt = new DataSet();
            adpter.Fill(dt, "Account");
            dtgv_Account.DataSource = dt.Tables["Account"];
        }

        public bool kiemtrathongtintaikhoan(string username)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "select count(*) from Account where UserName=@username";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@username", username);
            sqlConnection.Open();
            int count = (int)command.ExecuteScalar();
            sqlConnection.Close();
            return count > 0;
        }

        public void addAcount(string DisplayName, string UserName, string PassWord, string Type)
        {
            if (kiemtrathongtintaikhoan(UserName))
            {
                MessageBox.Show("Tài khoản bạn muốn thêm hiện đã có !");
            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection(connect);
                string query = "insert into Account(DisplayName,UserName,PassWord,Type) values (@DisplayName,@UserName,@PassWord,@Type)";

                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@DisplayName", DisplayName);
                cmd.Parameters.Add("@UserName", UserName);
                cmd.Parameters.Add("@PassWord", PassWord);
                cmd.Parameters.Add("@Type", Type);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Thêm dữ iệu thành công !");
            }
        }

        public void deletedataccount(string username)
        {
            if (kiemtrathongtintaikhoan(username))
            {
                SqlConnection sqlConnection = new SqlConnection(connect);
                string query = "delete from Account where UserName=@username";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", username);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Bạn xóa tài khoản thành công !");

            }
            else
            {
                MessageBox.Show("Tài khoản bàn muốn xóa không có !");
            }
        }

        public void updateaccount(string DisplayName, string UserName, string PassWord, string Type)
        {
            if (kiemtrathongtintaikhoan(UserName))
            {
                SqlConnection sqlConnection = new SqlConnection(connect);
                string query = "update Account set DisplayName=@Displayname, PassWord=@PassWord,Type=@Type where UserName=@UserName";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@DisplayName", DisplayName);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", PassWord);
                cmd.Parameters.AddWithValue("@Type", Type);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Tài khoản bạn cập nhật thành công !");


            }
            else
            {
                MessageBox.Show("Tài khoàn bạn muốn cập nhật không có !");
            }
        }
        public void searchtaikhoan(string DisplayName)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);

            string query = "select *from Account where DisplayName LIKE @DisplayName+'%'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            adapter.SelectCommand.Parameters.Add("@DisplayName", DisplayName);
            DataSet dt = new DataSet();
            adapter.Fill(dt, "Account");
            dtgv_Account.DataSource = dt.Tables["Account"];
        }

        public void databindingacount()
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(connect);
            }
            string query = "select *from Account";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet dt = new DataSet();
            adapter.Fill(dt, "Account");
            bs = new BindingSource(dt, "Account");
            txt_Display.DataBindings.Add("text", bs, "DisplayName");
            txt_nameaccount.DataBindings.Add("text", bs, "UserName");
            txtPasswordaccount.DataBindings.Add("text", bs, "PassWord");
            txt_type.DataBindings.Add("text", bs, "Type");

        }
        #endregion

        #region Events

        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_type.Text) || string.IsNullOrEmpty(txt_nameaccount.Text) || string.IsNullOrEmpty(txtPasswordaccount.Text) || string.IsNullOrEmpty(txt_type.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin !");
            }
            else
            {
                string displayname = txt_type.Text;
                string username = txt_nameaccount.Text;
                string password = txtPasswordaccount.Text;
                string type = int.Parse(txt_type.Text).ToString();
                addAcount(displayname, username, password, type);
                viewlistaccount();
                txt_type.Text = "";
                txt_nameaccount.Text = "";
                txtPasswordaccount.Text = "";
                txt_type.Text = "";
            }
        }

        private void btn_DeleteAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nameaccount.Text))
            {
                MessageBox.Show("Bạn vui lòng nhập thông tin tài khoản cần xóa !");
            }
            else
            {
                string username = txt_nameaccount.Text;
                deletedataccount(username);
                txt_type.Text = "";
                txt_nameaccount.Text = "";
                txtPasswordaccount.Text = "";
                txt_type.Text = "";

                txt_nameaccount.Focus();
                viewlistaccount();
            }
        }

        private void btn_EditAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nameaccount.Text))
            {
                MessageBox.Show("Bạn vui long nhập thông tin tài khoản cần cập nhật ! ");
            }
            else
            {
                string display = txt_type.Text;
                string username = txt_nameaccount.Text;
                string password = txtPasswordaccount.Text;
                string type = int.Parse(txt_type.Text).ToString();
                updateaccount(display, username, password, type);

                txt_type.Text = "";
                txt_nameaccount.Text = "";
                txtPasswordaccount.Text = "";
                txt_type.Text = "";

                txt_nameaccount.Focus();
                viewlistaccount();

            }
        }
     
        private void btn_ViewAccount_Click(object sender, EventArgs e)
        {
            viewlistaccount();
        
        }

        private void btn_SearchAccount_Click(object sender, EventArgs e)
        {
            string search = txt_SearchAccountName.Text;
            searchtaikhoan(search);
        }

        private void btn_FristAccount_Click(object sender, EventArgs e)
        {
            bs.Position = 0;
        }

        private void btn_PrevioursAccount_Click(object sender, EventArgs e)
        {

            if (bs.Position > 0)
            {
                bs.Position--;

            }
        }

        private void btn_NextAccount_Click(object sender, EventArgs e)
        {
            if (bs.Position < bs.Count - 1)
            {
                bs.Position++;
            }
        }

        private void btn_LastAccount_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Count - 1;
        }

        private void AdminAccount_Load(object sender, EventArgs e)
        {
            databindingacount();
        }
        #endregion


    }
}
