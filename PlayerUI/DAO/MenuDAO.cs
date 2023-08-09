using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBida.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set { instance = value; }
        }

        private MenuDAO() { }

        public List<DTO.Mennu> GetListMenuByTable(int id)
        {
            List<DTO.Mennu> listMenu = new List<DTO.Mennu>();
            string query = "select f.name, bi.count, f.price, f.price * bi.count as totalPrice from dbo.BILL as b,dbo.Food as f,dbo.BillInfo as bi where bi.idBill=b.id and bi.idFood=f.id and b.idTable =" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO.Mennu menu = new DTO.Mennu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
