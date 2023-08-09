using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanBida
{
    public partial class AdminCategory : Form
    {
        private string connect = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanBiDaFinal1;Integrated Security=True";
        BindingSource bs = null;
        public AdminCategory()
        {
            InitializeComponent();
            viewfoodcategory();
        }

        #region Methods
        public void viewfoodcategory()
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "select *from FoodCategory";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "FoodCategory");
            dtgv_Category.DataSource = ds.Tables["FoodCategory"];
        }

        public bool kiemtraidfoodcategoty(string id)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "select count(*) from FoodCategory where id=@id";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@id", id);
            sqlConnection.Open();
            int count = (int)command.ExecuteScalar();
            sqlConnection.Close();
            return count > 0;
        }

        public bool kiemtranamefoodcategoty(string name)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "select count(*) from FoodCategory where name=@name";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@name", name);
            sqlConnection.Open();
            int count = (int)command.ExecuteScalar();
            sqlConnection.Close();
            return count > 0;
        }

        public void addfoodcategory(string name)
        {
            if (kiemtranamefoodcategoty(name))
            {
                MessageBox.Show("danh mục thức ăn của bạn hiện đã có !");

            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection(connect);
                string query = "insert into FoodCategory(name)values(@name)";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.Add("@name", name);
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Thêm dữ liệu thành công !");
            }
        }

        public void deletefoodcategory(string id)
        {
            if (kiemtraidfoodcategoty(id))
            {
                SqlConnection sqlConnection = new SqlConnection(connect);
                string query = "delete from Foodcategory where id=@id";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@id", id);
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Xóa dữ liệu thành công !");

            }
            else
            {
                MessageBox.Show("dữ liệu bạn muốn xóa không tồn tại !");
            }
        }

        public void updatefoodcategory(string id, string name)
        {
            if (kiemtraidfoodcategoty(id))
            {
                SqlConnection sqlConnection = new SqlConnection(connect);
                string query = " update  Foodcategory set name=@name  where id=@id";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("cập nhật dữ liệu thành công !");

            }
            else
            {
                MessageBox.Show("dữ liệu bạn muốn cập nhật không tồn tại !");
            }
        }

        public void searchfoodcategory(string search)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "select *from FoodCategory where name LIKE @search+'%' ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            adapter.SelectCommand.Parameters.Add("@search", search);
            DataSet dt = new DataSet();
            adapter.Fill(dt, "FoodCategory");
            dtgv_Category.DataSource = dt.Tables["FoodCategory"];
        }

        public void databindingFoodCategory()
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            if (sqlConnection == null)
            {

                sqlConnection = new SqlConnection(connect);
            }
            string query = "select *from FoodCategory";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet dt = new DataSet();
            adapter.Fill(dt, "FoodCategory");
            bs = new BindingSource(dt, "FoodCategory");
            txt_idCategory.DataBindings.Add("text", bs, "id");
            txt_NameCategory.DataBindings.Add("text", bs, "name");

        }
        #endregion

        #region Events
        private void btn_AddCategory_Click(object sender, EventArgs e)
        {
            string tendanhmuc = txt_NameCategory.Text;
            addfoodcategory(tendanhmuc);
            viewfoodcategory();
        }

        private void btn_DeleteCategory_Click(object sender, EventArgs e)
        {
            string id = txt_idCategory.Text;
            deletefoodcategory(id);
            viewfoodcategory();
        }

        private void btn_EditCategory_Click(object sender, EventArgs e)
        {
            string id = txt_idCategory.Text;
            string name = txt_NameCategory.Text;
            updatefoodcategory(id, name);
            viewfoodcategory();
        }

        private void btn_SearchCategory_Click(object sender, EventArgs e)
        {
            string search = txt_SearchCategoryName.Text;
            searchfoodcategory(search);
        }

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

        private void AdminCategory_Load(object sender, EventArgs e)
        {
            databindingFoodCategory();
        }
        #endregion

        private void btn_ViewCategory_Click(object sender, EventArgs e)
        {
            viewfoodcategory();
        }
    }
}
