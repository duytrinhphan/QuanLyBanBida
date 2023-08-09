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
    public partial class AdminCustom : Form
    {
        private string connect = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanBiDaFinal1;Integrated Security=True";
        BindingSource bs = null;

        public AdminCustom()
        {
            InitializeComponent();
      
            xemdulieukhachang();
        }

        #region Methods
        public void xemdulieukhachang()
        {
            SqlConnection conn = new SqlConnection(connect);
            string query = "select idcustomer as[Mã khách hàng],name as[Tên khách hàng],gender as[Giới tính],phonenumber as[Số điện thoại], daycheckin as[Ngày checkin],idcategorycustomer as[Loại khách hàng] from Customer";
            SqlDataAdapter adpater = new SqlDataAdapter(query, conn);
            DataSet dt = new DataSet();
            adpater.Fill(dt, "Customer");
            dtgv_Customer.DataSource = dt.Tables["Customer"];
        }
        public bool KiemTraTonTai(string idcustomer)
        {
            SqlConnection conn = new SqlConnection(connect);
            string query = "SELECT COUNT(*) FROM Customer WHERE idcustomer = @idcustomer";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idcustomer", idcustomer);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count > 0;
        }
        public void themkhachang(string idcustomer, string name, string gender, string phonenumber, string daycheckin, string idcatgorycustomer)
        {
            try
            {

                SqlConnection conn = new SqlConnection(connect);
                string query = "insert into Customer(idcustomer,name,gender,phonenumber, daycheckin,idcategorycustomer) values(@idcustomer,@name,@gender,@phonenumber, @daycheckin,@idcategorycustomer)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@idcustomer", idcustomer);
                cmd.Parameters.Add("@name", name);
                cmd.Parameters.Add("@gender", gender);
                cmd.Parameters.Add("@phonenumber", phonenumber);
                cmd.Parameters.Add("@daycheckin", daycheckin);
                cmd.Parameters.Add("@idcategorycustomer", idcatgorycustomer);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Bạn đã thêm thành công !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã Khách hàng đã tồn tại");
            }
        }

        void deletecustomer(string idcustomer)
        {
            if (KiemTraTonTai(idcustomer))
            {
                SqlConnection sqlConnection = new SqlConnection(connect);
                string query = "delete from Customer where idcustomer=@idcustomer";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idcustomer", idcustomer);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Bạn đã xóa dữ liệu thành công !");
            }
            else
            {
                MessageBox.Show("Khách hàng bạn muốn xóa không tồn tại !");
            }
        }

        public void updatekhachanh(string idcustomer, string name, string gender, string phonenumber, string daycheckin, string idcategorycustomer)
        {
            if (KiemTraTonTai(idcustomer))
            {
                SqlConnection sqlConnection = new SqlConnection(connect);
                string query = "update Customer set name=@name, gender=@gender,phonenumber=@phonenumber, daycheckin=@daycheckin,idcategorycustomer=@idcategorycustomer where idcustomer=@idcustomer";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idcustomer", idcustomer);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@phonenumber", phonenumber);
                cmd.Parameters.AddWithValue("@daycheckin", daycheckin);
                cmd.Parameters.AddWithValue("@idcategorycustomer", idcategorycustomer);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Bạn đã cập nhật thành công !");
            }
            else
            {
                MessageBox.Show("Khách hàng bạn muốn cập nhật không tồn tại !");
            }
        }

        public void databindingcustomer()
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            if (sqlConnection == null)
            {

                sqlConnection = new SqlConnection(connect);
            }
            string query = "select *from Customer";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet dt = new DataSet();
            adapter.Fill(dt, "Customer");
            bs = new BindingSource(dt, "Customer");
            txt_IDCustomer.DataBindings.Add("text", bs, "idcustomer");
            txt_NameCustomer.DataBindings.Add("text", bs, "name");
            txt_SexCustomer.DataBindings.Add("text", bs, "gender");
            txt_PhoneNumberCustomer.DataBindings.Add("text", bs, "phonenumber");
            txt_DateCheckin.DataBindings.Add("text", bs, "daycheckin");
            txt_CategoryCustomer.DataBindings.Add("text", bs, "idcategorycustomer");

        }
        public void searchcustomer(string name)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "select *from Customer where name LIKE @name +'%'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            adapter.SelectCommand.Parameters.Add("@name", name);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Customer");
            dtgv_Customer.DataSource = ds.Tables["Customer"];
        }

        #endregion

        #region Events
        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IDCustomer.Text) || string.IsNullOrEmpty(txt_NameCustomer.Text) || string.IsNullOrEmpty(txt_SexCustomer.Text))
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu ");
            }
            else
            {
                string idcustomer = txt_IDCustomer.Text;
                string name = txt_NameCustomer.Text;
                string gender = txt_SexCustomer.Text;
                string phonenumber = txt_PhoneNumberCustomer.Text;
                string daycheckin = txt_PhoneNumberCustomer.Text;
                string idcatgorycustomer = txt_CategoryCustomer.Text;
                themkhachang(idcustomer, name, gender, phonenumber, daycheckin, idcatgorycustomer);
                xemdulieukhachang();
                txt_IDCustomer.Text = "";
                txt_NameCustomer.Text = "";
                txt_SexCustomer.Text = "";
                txt_DateCheckin.Text = "";
                txt_PhoneNumberCustomer.Text = "";
                txt_CategoryCustomer.Text = "";
            }
        }

        private void btn_DeleteCustomer_Click(object sender, EventArgs e)
        {
            string ma = txt_IDCustomer.Text;
            deletecustomer(ma);
            xemdulieukhachang();
            txt_IDCustomer.Text = "";
            txt_NameCustomer.Text = "";
            txt_SexCustomer.Text = "";
            txt_DateCheckin.Text = "";
            txt_PhoneNumberCustomer.Text = "";
            txt_CategoryCustomer.Text = "";
        }

        private void btn_EditCustomer_Click(object sender, EventArgs e)
        {
            string idcustomer = txt_IDCustomer.Text;
            string name = txt_NameCustomer.Text;
            string gender = txt_SexCustomer.Text;
            string phonenumber = txt_PhoneNumberCustomer.Text;
            string daycheckin = txt_DateCheckin.Text;
            string idcatgorycustomer = txt_CategoryCustomer.Text;
            updatekhachanh(idcustomer, name, gender, phonenumber, daycheckin, idcatgorycustomer);
            xemdulieukhachang();
            txt_IDCustomer.Text = "";
            txt_NameCustomer.Text = "";
            txt_SexCustomer.Text = "";
            txt_DateCheckin.Text = "";
            txt_PhoneNumberCustomer.Text = "";
            txt_CategoryCustomer.Text = "";
        }
        #endregion

        private void btn_FristCustomer_Click(object sender, EventArgs e)
        {
            bs.Position = 0;
        }

        private void btn_PrevioursCustomer_Click(object sender, EventArgs e)
        {

            if (bs.Position > 0)
            {
                bs.Position--;
            }
        }

        private void btn_NextCustomer_Click(object sender, EventArgs e)
        {
            if (bs.Position < bs.Count - 1)
            {

                bs.Position++;
            }
        }

        private void btn_LastCustomer_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Count - 1;
        }

        private void btn_SearchCustomer_Click(object sender, EventArgs e)
        {
            string name=txt_NameCustomer.Text;
            searchcustomer(name);

        }

        private void AdminCustom_Load(object sender, EventArgs e)
        {
            databindingcustomer();
        }
    }
}
