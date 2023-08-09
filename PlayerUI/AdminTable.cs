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
    public partial class AdminTable : Form
    {
        private string connect = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanBiDaFinal1;Integrated Security=True";
        BindingSource bs = null;  
        public AdminTable()
        {
            InitializeComponent();
            viewListTable();

        }

        #region Methods
        public void viewListTable()
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "select id as [ID], name as [Name], status as [Status] from dbo.TableBida ";
            SqlDataAdapter adpter = new SqlDataAdapter(query, sqlConnection);
            DataSet dt = new DataSet();
            adpter.Fill(dt, "TableBida");
            dtgv_Table.DataSource = dt.Tables["TableBida"];
        }

        public bool kiemTraNameTable(object name)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "select count(*) from TableBida where name=@name";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@name", name);
            sqlConnection.Open();
            int count = (int)command.ExecuteScalar();
            sqlConnection.Close();
            return count > 0;
        }

        public bool kiemTraIDTable(object id)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "select count(*) from TableBida where id=@id";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@id", id);
            sqlConnection.Open();
            int count = (int)command.ExecuteScalar();
            sqlConnection.Close();
            return count > 0;
        }


        public void addTable(string name, string status)
        {

            if (kiemTraNameTable(name))
            {
                MessageBox.Show("Bàn bạn muốn thêm hiện đã có !");
            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection(connect);
                string query = "insert into TableBida(name,status) values (@name,@status)";

                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@name", name);
                cmd.Parameters.Add("@status", status);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Thêm dữ liệu thành công !");
            }
        }

        public void deleteTable(int id)
        {
            if (kiemTraIDTable(id))
            {
                SqlConnection sqlConnection = new SqlConnection(connect);
                string query = "delete from TableBida where id=@id";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Xóa bàn thành công !");
            }
            else
            {
                MessageBox.Show("Tài khoản bàn muốn xóa không có !");
            }
        }

        public void updateTable(int id, string name, string status)
        {
            if (kiemTraIDTable(id))
            {
                SqlConnection sqlConnection = new SqlConnection(connect);
                string query = "update TableBida set name=@name, status=@status where id=@id";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@status", status);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Bàn đã cập nhật thành công !");
            }
            else
            {
                MessageBox.Show("Bàn bạn muốn cập nhật không có !");
            }
        }


        public void databindingtable()
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(connect);
            }
            string query = "select *from TableBida";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet dt = new DataSet();
            adapter.Fill(dt, "TableBida");
            bs = new BindingSource(dt, "TableBida");
            txt_idtable.DataBindings.Add("text", bs, "id");
            txt_TableName.DataBindings.Add("text", bs, "name");
            cb_TableStatus.DataBindings.Add("text", bs, "status");




        }

        public void searchtable(string status)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "select *from TableBida where status LIKE @status +'%' ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            adapter.SelectCommand.Parameters.Add("@status", status);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "TableBida");
            dtgv_Table.DataSource = ds.Tables["TableBida"];
        }


        #endregion

        #region Events
        private void btn_AddTable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TableName.Text) || string.IsNullOrEmpty(cb_TableStatus.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin !");
            }
            else
            {

                string tablename = txt_TableName.Text;
                string tablestatus = cb_TableStatus.Text;
                addTable(tablename, tablestatus);
                viewListTable();
                txt_TableName.Text = "";
                cb_TableStatus.Text = "";
            }
        }

        private void btn_DeleteTable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idtable.Text))
            {
                MessageBox.Show("Bạn vui lòng nhập mã số bàn cần xóa !");
            }
            else
            {
                int id = int.Parse(txt_idtable.Text);
                deleteTable(id);
                txt_idtable.Text = "";
                txt_TableName.Text = "";
                cb_TableStatus.Text = "";
                txt_idtable.Focus();
                viewListTable();
            }
        }

        private void btn_EditTable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idtable.Text))
            {
                MessageBox.Show("Bạn vui long nhập mã số cần cập nhật ! ");
            }
            else
            {
                int id = int.Parse(txt_idtable.Text);
                string name = txt_TableName.Text;
                string status = cb_TableStatus.Text;
                updateTable(id, name, status);
                txt_TableName.Text = "";
                cb_TableStatus.Text = "";
                txt_idtable.Focus();
                viewListTable();

            }
        }
        #endregion

        private void btn_FristCategory_Click(object sender, EventArgs e)
        {
            bs.Position = 0;
        }

        private void btn_PrevioursCategory_Click(object sender, EventArgs e)
        {
            if (bs.Position > 0)
            {
                bs.Position--;
            }
        }

        private void btn_NextCategory_Click(object sender, EventArgs e)
        {
            if (bs.Position < bs.Count - 1)
            {

                bs.Position++;
            }
        }

        private void btn_LastCategory_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Count - 1;
        }

        private void btn_SearchTable_Click(object sender, EventArgs e)
        {
            string search=txt_SearchTableName.Text;
            searchtable(search);
        }

        private void AdminTable_Load(object sender, EventArgs e)
        {
            databindingtable();
        }

        private void btn_ViewTable_Click(object sender, EventArgs e)
        {
            viewListTable();
        }
    }
}
