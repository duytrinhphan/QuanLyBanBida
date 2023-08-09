using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBida.DTO
{
    public class BillInfo
    {
        private int id;
        private int billID;
        private int foodID;
        private int count;


        public int Id { get => id; set => id = value; }
        public int BillID { get => billID; set => billID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int Count { get => count; set => count = value; }

        public BillInfo(DataRow row)
        {
            Id = (int)row["id"];
            BillID = (int)row["idBill"];
            FoodID = (int)row["idFood"];
            Count = (int)row["count"];
        }
    }
}
