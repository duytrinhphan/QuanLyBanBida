using QuanLyBanBida.DAO;
using QuanLyBanBida.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Drawing.Layout;
using System.IO;

namespace QuanLyBanBida
{
    public partial class f_TableManager : Form
    {
        public f_TableManager()
        {
            InitializeComponent();
            Table();
            LoadCategory();
            LoadComboBoxTable(cb_SwitchTable);
        }
        #region Methods
        public void Table()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    case "Có Người":
                        btn.BackColor = Color.DarkRed;
                        break;
                }
                flpTable.Controls.Add(btn);
                btn.TextImageRelation = TextImageRelation.ImageAboveText;
                btn.Font = new Font("Time new roman", 7, FontStyle.Bold);
                // Căn giữa văn bản
                btn.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QuanLyBanBida.DTO.Mennu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            double totalPrice = 0;
            foreach (QuanLyBanBida.DTO.Mennu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txttongtien.Text = totalPrice.ToString("c", culture);
        }

        void LoadComboBoxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbfood.DataSource = listFood;
            cbfood.DisplayMember = "Name";
        }

        private string GenerateBillText(int tableID, double discount, double timeplayprice, double totalPrice, double finalTotalPrice)
        {
            StringBuilder billText = new StringBuilder();
            string FoodName = "Tên món";
            string Count = "Số lượng";
            string Price = "Đơn giá";
            string TotalPrice = "Tổng tiền món";
            billText.AppendLine($"HÓA ĐƠN BÀN {tableID}");
            billText.AppendLine("".PadRight(72, '-')); // 72 is the total width of the line

            List<QuanLyBanBida.DTO.Mennu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(tableID);
            billText.AppendLine($"{FoodName,0}{Count,20}{Price,20}{TotalPrice,20}");
            foreach (QuanLyBanBida.DTO.Mennu item in listBillInfo)
            {
                billText.AppendLine($"{item.FoodName,0}{item.Count,22}{item.Price,24}{item.TotalPrice,25}");
            }

            billText.AppendLine("".PadRight(72, '-')); // Add a line to separate items from total section
            CultureInfo culture = new CultureInfo("vi-VN");
            billText.AppendLine($"Tổng tiền: {totalPrice.ToString("c", culture)}");
            billText.AppendLine($"Giảm giá: {discount}%");
            billText.AppendLine($"Tiền giờ: {timeplayprice.ToString("c", culture)}");
            billText.AppendLine($"Tổng cộng: {finalTotalPrice.ToString("c", culture)}");

            return billText.ToString();
        }

        private void SaveBillToPdf(int tableID, string billText)
        {
            int fileIndex = 1;
            string filePath = $"Bill_Table_{tableID}_{fileIndex}.pdf";

            while (File.Exists(filePath))
            {
                fileIndex++;
                filePath = $"Bill_Table_{tableID}_{fileIndex}.pdf";
            }

            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XFont font = new XFont("times new roman", 14, XFontStyle.Regular);
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XRect rect = new XRect(80, 80, page.Width - 80, page.Height - 80);
            XTextFormatter tf = new XTextFormatter(gfx);
            tf.Alignment = XParagraphAlignment.Left;
            tf.DrawString(billText, font, XBrushes.Black, rect);

            document.Save(filePath);
            document.Close();
            System.Diagnostics.Process.Start(filePath);
        }


        #endregion

        #region Events
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = ((sender as Button).Tag);
            ShowBill(tableID);
        }
        #endregion

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.Id;
            LoadFoodListByCategoryID(id);
        }

        private void btn_AddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbfood.SelectedItem as Food).Id;
            int count = (int)nmFoodCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.ID);

            Table();
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nm_Discount.Value;
            if (string.IsNullOrEmpty(txt_StartTime.Text) || string.IsNullOrEmpty(txt_EndTime.Text))
            {
                MessageBox.Show("Bạn vui long nhập thời gian thanh toán tiền !");
            }
            else
            {
                double timedefault = 50;
                double starttime = Convert.ToDouble(txt_StartTime.Text);
                double endtime = Convert.ToDouble(txt_EndTime.Text);
                double timeplay = endtime - starttime;
                double timeplayprice = timeplay * timedefault;

                double totalPrice = Convert.ToDouble(txttongtien.Text.Split(',')[0]);
                double finalTotalPrice = timeplayprice + (totalPrice - (totalPrice / 100) * discount);

                if (idBill != -1)
                {
                    string billText = GenerateBillText(table.ID, discount, timeplayprice, totalPrice, finalTotalPrice);
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thanh toán tiền bàn không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                        BillDAO.Instance.DeleteBillInfoByBillID(idBill);
                        SaveBillToPdf(table.ID, billText);
                        Table();
                    }   
                }
            }
        }

        private void btn_SwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID;

            int id2 = (cb_SwitchTable.SelectedItem as Table).ID;
            if(id1 == id2)
            {
                MessageBox.Show("Vui lòng chọn bàn muốn chuyển sang");
                return;
            }
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cb_SwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);

                Table();
            }
        }
    }
}
