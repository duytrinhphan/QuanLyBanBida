namespace QuanLyBanBida
{
    partial class f_AdminBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_AdminBill));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ViewBill = new System.Windows.Forms.Button();
            this.dtpk_ToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpk_FromDate = new System.Windows.Forms.DateTimePicker();
            this.dtgv_Bill = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ViewBill);
            this.panel2.Controls.Add(this.dtpk_ToDate);
            this.panel2.Controls.Add(this.dtpk_FromDate);
            this.panel2.Location = new System.Drawing.Point(252, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 47);
            this.panel2.TabIndex = 3;
            // 
            // btn_ViewBill
            // 
            this.btn_ViewBill.BackColor = System.Drawing.Color.Silver;
            this.btn_ViewBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewBill.ForeColor = System.Drawing.Color.Black;
            this.btn_ViewBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_ViewBill.Image")));
            this.btn_ViewBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewBill.Location = new System.Drawing.Point(299, 0);
            this.btn_ViewBill.Name = "btn_ViewBill";
            this.btn_ViewBill.Size = new System.Drawing.Size(129, 47);
            this.btn_ViewBill.TabIndex = 2;
            this.btn_ViewBill.Text = "   Thống kê";
            this.btn_ViewBill.UseVisualStyleBackColor = false;
            this.btn_ViewBill.Click += new System.EventHandler(this.btn_ViewBill_Click);
            // 
            // dtpk_ToDate
            // 
            this.dtpk_ToDate.Location = new System.Drawing.Point(522, 13);
            this.dtpk_ToDate.Name = "dtpk_ToDate";
            this.dtpk_ToDate.Size = new System.Drawing.Size(169, 22);
            this.dtpk_ToDate.TabIndex = 1;
            // 
            // dtpk_FromDate
            // 
            this.dtpk_FromDate.Location = new System.Drawing.Point(14, 13);
            this.dtpk_FromDate.Name = "dtpk_FromDate";
            this.dtpk_FromDate.Size = new System.Drawing.Size(171, 22);
            this.dtpk_FromDate.TabIndex = 0;
            // 
            // dtgv_Bill
            // 
            this.dtgv_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Bill.Location = new System.Drawing.Point(329, 96);
            this.dtgv_Bill.Name = "dtgv_Bill";
            this.dtgv_Bill.RowHeadersWidth = 51;
            this.dtgv_Bill.RowTemplate.Height = 24;
            this.dtgv_Bill.Size = new System.Drawing.Size(553, 472);
            this.dtgv_Bill.TabIndex = 3;
            // 
            // f_AdminBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1144, 626);
            this.Controls.Add(this.dtgv_Bill);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "f_AdminBill";
            this.Text = "Thông tin hóa đơn";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ViewBill;
        private System.Windows.Forms.DateTimePicker dtpk_ToDate;
        private System.Windows.Forms.DateTimePicker dtpk_FromDate;
        private System.Windows.Forms.DataGridView dtgv_Bill;
    }
}