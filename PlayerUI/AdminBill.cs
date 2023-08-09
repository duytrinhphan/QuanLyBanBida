using QuanLyBanBida.DAO;
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
    public partial class f_AdminBill : Form
    {
        private string connect = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanBiDaFinal1;Integrated Security=True";
        BindingSource bs = null;
        public f_AdminBill()
        {
            InitializeComponent();
            LoadData();
        }

        #region Methods
        void LoadData()
        {
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpk_FromDate.Value, dtpk_ToDate.Value);
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpk_FromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpk_ToDate.Value = dtpk_FromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgv_Bill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        #endregion

        #region Events
        private void btn_ViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpk_FromDate.Value, dtpk_ToDate.Value);
        }
        #endregion


    }
}
