using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBida.DTO
{
    public class Mennu
    {
        private string foodName;
        private int count;
        private Double price;
        private Double totalPrice;

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public Double Price { get => price; set => price = value; }
        public Double TotalPrice { get => totalPrice; set => totalPrice = value; }

        public Mennu(DataRow row)
        {
            FoodName = row["Name"].ToString();
            Count = (int)row["count"];
            Price = (Double)row["price"];
            TotalPrice = (Double)row["totalPrice"];
        }
    }
}
