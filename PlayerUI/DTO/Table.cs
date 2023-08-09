using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBida.DTO
{
    public class Table
    {
        private int iD;
        private string name;
        private string status;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = (string)row["Name"].ToString();
            this.Status = row["Status"].ToString();
        }
    }
}
