using QuanLyBanBida.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBida.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            string query = "USP_Login @userName , @passWord"; // ở đây em khai báo câu truy vấn = prodieu 

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord /*list*/});

            return result.Rows.Count > 0;
        }

        public Account GetAccountByUserName(string userName)//để phân quyền được , thì em tạo 1 hàm GetAccountByUserName, mục đích là lấy account = username mình truyền vào
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from account where userName = '" + userName + "'"); // khai báo biến data của dữ liệu datatable để thực hiện câu truy vấn ,
            foreach (DataRow item in data.Rows)//chạy 1 vòng foreach để tìm tất cả account có userName = userName mình truyền vào từ chương trình
            {
                return new Account(item); // nếu có account thì giá trị của hàm sẽ trả về account đó
            }

            return null;//nếu k thì nó sẽ null
        }

        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] { userName, displayName, pass, newPass });

            return result > 0;
        }

        public bool ResetPassword(string name)
                {
                    string query = string.Format("update account set password = N'1' where UserName = N'{0}'", name);
                    int result = DataProvider.Instance.ExecuteNonQuery(query);

                    return result > 0;
                }
    }
}
