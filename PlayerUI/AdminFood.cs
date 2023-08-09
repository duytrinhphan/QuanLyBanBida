using QuanLyBanBida.DAO;
using QuanLyBanBida.DTO;
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
using System.Xml.Linq;

namespace QuanLyBanBida
{
    public partial class AdminFood : Form
    {
        private string connect = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanBiDaFinal1;Integrated Security=True";
        BindingSource bs = null;
        public AdminFood()
        {
            InitializeComponent();
           
        }
        public bool kiemtrafoodid(string id)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "select count(*) from Food where id=@id ";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@id", id);
            sqlConnection.Open();
            int count = (int)command.ExecuteScalar();
            sqlConnection.Close();
            return count > 0;
        }

        public bool kiemtrafoodname(string name)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "select count(*) from Food where name=@name ";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@name", name);
            sqlConnection.Open();
            int count = (int)command.ExecuteScalar();
            sqlConnection.Close();
            return count > 0;
        }

        public void viewfood()
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "select *from Food";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Food");
            dtgv_Food.DataSource = ds.Tables["Food"];


        }



        public void addfood(string name, string idcategory, string price)
        {
            if (kiemtrafoodname(name))
            {
                MessageBox.Show("Dữ liệu bạn muốn thêm đã tồn tại !");
            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection(connect);
                string query = "insert into Food(name,idCategory,price) values(@name,@idcategory,@price)";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                command.Parameters.Add("@name", name);
                command.Parameters.Add("@idcategory", idcategory);
                command.Parameters.Add("@price", double.Parse(price));
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Bạn thêm dữ liệu thành công !");

            }
        }

        public void deletefood(string name)
        {
            try
            {
                if (kiemtrafoodname(name))
                {
                    SqlConnection sqlConnection = new SqlConnection(connect);
                    string query = "delete from Food where name=@name";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@name", name);
                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Xóa dữ liệu thành công !");

                }
                else
                {
                    MessageBox.Show("Dữ liệu bạn muốn xóa không có !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thức ăn bạn muốn xóa đang tồn tại !");
            }
        }


        public void updatefood(string id, string name, string idcategory, float price)
        {
            try
            {
                if (kiemtrafoodid(id))
                {
                    SqlConnection sqlConnection = new SqlConnection(connect);
                    string query = "update Food set name=@name ,idCategory=@idcategory,price=@price where id=@id";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@idcategory", idcategory);
                    command.Parameters.AddWithValue("@price", price);
                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Cập nhật dữ liệu thành công !");

                }
                else
                {
                    MessageBox.Show("Dữ liệu bạn muốn cập nhật không có !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thức ăn bạn muốn cập nhật  ssss đang tồn tại !");
            }
        }

        public void searchfood(string name)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "select *from Food where name LIKE @name+'%'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            adapter.SelectCommand.Parameters.Add("@name", name);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Food");
            dtgv_Food.DataSource = ds.Tables["Food"];
        }



        #region Methods


        public void databindingfood()
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            if (sqlConnection == null)
            {

                sqlConnection = new SqlConnection(connect);
            }
            string query = "select *from Food";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet dt = new DataSet();
            adapter.Fill(dt, "Food");
            bs = new BindingSource(dt, "Food");
            txt_idFood.DataBindings.Add("text", bs, "id");
            txt_NameFood.DataBindings.Add("text", bs, "name");
            cb_Category.DataBindings.Add("text", bs, "idCategory");
            txt_Price.DataBindings.Add("text", bs, "price");
            

        }
      
        #endregion


        #region Events

        #endregion

        private void btn_AddFood_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_NameFood.Text) || string.IsNullOrEmpty(cb_Category.Text) || string.IsNullOrEmpty(txt_Price.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin !");
            }
            else
            {

                string name;
                string idcategory;
                string price;


                name = txt_NameFood.Text;
                idcategory = cb_Category.Text;
                price = txt_Price.Text;

                addfood(name, idcategory, price);

                viewfood();

                txt_NameFood.Text = "";
                cb_Category.Text = "";
                txt_Price.Text = "";

            }

        }

        private void btn_DeleteFood_Click(object sender, EventArgs e)
        {
            string name = txt_NameFood.Text;
            deletefood(name);
            viewfood();

        }

        private void btn_EditFood_Click(object sender, EventArgs e)
        {
            string id = txt_idFood.Text;
            string name = txt_NameFood.Text;
            string idcategory = cb_Category.Text;
            float price = float.Parse(txt_Price.Text);
            updatefood(id, name, idcategory, price);
            viewfood();
            txt_idFood.Text = "";
            txt_NameFood.Text = "";
            cb_Category.Text = "";
            txt_Price.Text = "";
        }



        private void btn_ViewFood_Click(object sender, EventArgs e)
        {
            viewfood();
        }

        private void AdminFood_Load(object sender, EventArgs e)
        {
            viewfood();
            databindingfood();
            
        }
        private void btn_SearchFood_Click(object sender, EventArgs e)
        {
            string search=txt_SearchFoodName.Text;
            searchfood(search);
        }

        private void btn_FristFood_Click(object sender, EventArgs e)
        {
            bs.Position = 0;
        }

        private void btn_PrevioursFood_Click(object sender, EventArgs e)
        {
            if (bs.Position > 0)
            {
                bs.Position--;

            }
        }

        private void btn_NextFood_Click(object sender, EventArgs e)
        {
            if (bs.Position < bs.Count - 1)
            {
                bs.Position++;
            }
        }

        private void btn_LastFood_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Count - 1;
        }
    }
}
