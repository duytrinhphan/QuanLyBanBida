namespace QuanLyBanBida
{
    partial class AdminFood
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFood));
            this.dtgv_Food = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_ViewFood = new System.Windows.Forms.Button();
            this.btn_EditFood = new System.Windows.Forms.Button();
            this.btn_DeleteFood = new System.Windows.Forms.Button();
            this.btn_AddFood = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_SearchFoodName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_SearchFood = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txt_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_FoodPrice = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cb_Category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_NameFood = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_NameFood = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_idFood = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_FoodID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_LastFood = new System.Windows.Forms.Button();
            this.btn_PrevioursFood = new System.Windows.Forms.Button();
            this.btn_NextFood = new System.Windows.Forms.Button();
            this.btn_FristFood = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Food)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_Food
            // 
            this.dtgv_Food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Food.Location = new System.Drawing.Point(61, 133);
            this.dtgv_Food.Name = "dtgv_Food";
            this.dtgv_Food.RowHeadersWidth = 51;
            this.dtgv_Food.RowTemplate.Height = 24;
            this.dtgv_Food.Size = new System.Drawing.Size(447, 432);
            this.dtgv_Food.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_ViewFood);
            this.panel5.Controls.Add(this.btn_EditFood);
            this.panel5.Controls.Add(this.btn_DeleteFood);
            this.panel5.Controls.Add(this.btn_AddFood);
            this.panel5.Location = new System.Drawing.Point(603, 123);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(534, 59);
            this.panel5.TabIndex = 4;
            // 
            // btn_ViewFood
            // 
            this.btn_ViewFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btn_ViewFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewFood.ForeColor = System.Drawing.Color.White;
            this.btn_ViewFood.Location = new System.Drawing.Point(456, 3);
            this.btn_ViewFood.Name = "btn_ViewFood";
            this.btn_ViewFood.Size = new System.Drawing.Size(75, 53);
            this.btn_ViewFood.TabIndex = 4;
            this.btn_ViewFood.Text = "Xem";
            this.btn_ViewFood.UseVisualStyleBackColor = false;
            this.btn_ViewFood.Click += new System.EventHandler(this.btn_ViewFood_Click);
            // 
            // btn_EditFood
            // 
            this.btn_EditFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btn_EditFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditFood.ForeColor = System.Drawing.Color.White;
            this.btn_EditFood.Location = new System.Drawing.Point(305, 3);
            this.btn_EditFood.Name = "btn_EditFood";
            this.btn_EditFood.Size = new System.Drawing.Size(75, 53);
            this.btn_EditFood.TabIndex = 3;
            this.btn_EditFood.Text = "Sửa";
            this.btn_EditFood.UseVisualStyleBackColor = false;
            this.btn_EditFood.Click += new System.EventHandler(this.btn_EditFood_Click);
            // 
            // btn_DeleteFood
            // 
            this.btn_DeleteFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btn_DeleteFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteFood.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteFood.Location = new System.Drawing.Point(153, 3);
            this.btn_DeleteFood.Name = "btn_DeleteFood";
            this.btn_DeleteFood.Size = new System.Drawing.Size(75, 53);
            this.btn_DeleteFood.TabIndex = 2;
            this.btn_DeleteFood.Text = "Xóa";
            this.btn_DeleteFood.UseVisualStyleBackColor = false;
            this.btn_DeleteFood.Click += new System.EventHandler(this.btn_DeleteFood_Click);
            // 
            // btn_AddFood
            // 
            this.btn_AddFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btn_AddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddFood.ForeColor = System.Drawing.Color.White;
            this.btn_AddFood.Location = new System.Drawing.Point(3, 3);
            this.btn_AddFood.Name = "btn_AddFood";
            this.btn_AddFood.Size = new System.Drawing.Size(75, 53);
            this.btn_AddFood.TabIndex = 1;
            this.btn_AddFood.Text = "Thêm";
            this.btn_AddFood.UseVisualStyleBackColor = false;
            this.btn_AddFood.Click += new System.EventHandler(this.btn_AddFood_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_SearchFoodName);
            this.panel6.Controls.Add(this.btn_SearchFood);
            this.panel6.Location = new System.Drawing.Point(22, 29);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1115, 59);
            this.panel6.TabIndex = 6;
            // 
            // txt_SearchFoodName
            // 
            this.txt_SearchFoodName.Animated = true;
            this.txt_SearchFoodName.AutoRoundedCorners = true;
            this.txt_SearchFoodName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txt_SearchFoodName.BorderRadius = 19;
            this.txt_SearchFoodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchFoodName.DefaultText = "";
            this.txt_SearchFoodName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SearchFoodName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SearchFoodName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchFoodName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchFoodName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txt_SearchFoodName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchFoodName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_SearchFoodName.ForeColor = System.Drawing.Color.White;
            this.txt_SearchFoodName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchFoodName.Location = new System.Drawing.Point(39, 15);
            this.txt_SearchFoodName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SearchFoodName.Name = "txt_SearchFoodName";
            this.txt_SearchFoodName.PasswordChar = '\0';
            this.txt_SearchFoodName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_SearchFoodName.PlaceholderText = "";
            this.txt_SearchFoodName.SelectedText = "";
            this.txt_SearchFoodName.Size = new System.Drawing.Size(918, 41);
            this.txt_SearchFoodName.TabIndex = 29;
            // 
            // btn_SearchFood
            // 
            this.btn_SearchFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btn_SearchFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchFood.ForeColor = System.Drawing.Color.White;
            this.btn_SearchFood.Location = new System.Drawing.Point(987, 15);
            this.btn_SearchFood.Name = "btn_SearchFood";
            this.btn_SearchFood.Size = new System.Drawing.Size(125, 41);
            this.btn_SearchFood.TabIndex = 5;
            this.btn_SearchFood.Text = "Tìm kiếm";
            this.btn_SearchFood.UseVisualStyleBackColor = false;
            this.btn_SearchFood.Click += new System.EventHandler(this.btn_SearchFood_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Location = new System.Drawing.Point(606, 241);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 207);
            this.panel4.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txt_Price);
            this.panel10.Controls.Add(this.lbl_FoodPrice);
            this.panel10.Location = new System.Drawing.Point(0, 163);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(531, 42);
            this.panel10.TabIndex = 4;
            // 
            // txt_Price
            // 
            this.txt_Price.Animated = true;
            this.txt_Price.AutoRoundedCorners = true;
            this.txt_Price.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txt_Price.BorderRadius = 14;
            this.txt_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Price.DefaultText = "";
            this.txt_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txt_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_Price.ForeColor = System.Drawing.Color.White;
            this.txt_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.Location = new System.Drawing.Point(120, 7);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.PasswordChar = '\0';
            this.txt_Price.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_Price.PlaceholderText = "";
            this.txt_Price.SelectedText = "";
            this.txt_Price.Size = new System.Drawing.Size(335, 30);
            this.txt_Price.TabIndex = 33;
            // 
            // lbl_FoodPrice
            // 
            this.lbl_FoodPrice.AutoSize = true;
            this.lbl_FoodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FoodPrice.ForeColor = System.Drawing.Color.White;
            this.lbl_FoodPrice.Location = new System.Drawing.Point(52, 15);
            this.lbl_FoodPrice.Name = "lbl_FoodPrice";
            this.lbl_FoodPrice.Size = new System.Drawing.Size(53, 22);
            this.lbl_FoodPrice.TabIndex = 0;
            this.lbl_FoodPrice.Text = "Giá: ";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cb_Category);
            this.panel9.Controls.Add(this.lbl_Category);
            this.panel9.Location = new System.Drawing.Point(0, 121);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(531, 46);
            this.panel9.TabIndex = 3;
            // 
            // cb_Category
            // 
            this.cb_Category.AutoRoundedCorners = true;
            this.cb_Category.BackColor = System.Drawing.Color.Transparent;
            this.cb_Category.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.cb_Category.BorderRadius = 17;
            this.cb_Category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Category.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.cb_Category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Category.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Category.ForeColor = System.Drawing.Color.White;
            this.cb_Category.ItemHeight = 30;
            this.cb_Category.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_Category.Location = new System.Drawing.Point(120, 3);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(333, 36);
            this.cb_Category.TabIndex = 8;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.White;
            this.lbl_Category.Location = new System.Drawing.Point(3, 10);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(111, 22);
            this.lbl_Category.TabIndex = 0;
            this.lbl_Category.Text = "Danh Mục: ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txt_NameFood);
            this.panel8.Controls.Add(this.lbl_NameFood);
            this.panel8.Location = new System.Drawing.Point(0, 81);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(531, 38);
            this.panel8.TabIndex = 3;
            // 
            // txt_NameFood
            // 
            this.txt_NameFood.Animated = true;
            this.txt_NameFood.AutoRoundedCorners = true;
            this.txt_NameFood.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txt_NameFood.BorderRadius = 14;
            this.txt_NameFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NameFood.DefaultText = "";
            this.txt_NameFood.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NameFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NameFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NameFood.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NameFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txt_NameFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NameFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_NameFood.ForeColor = System.Drawing.Color.White;
            this.txt_NameFood.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NameFood.Location = new System.Drawing.Point(120, 2);
            this.txt_NameFood.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NameFood.Name = "txt_NameFood";
            this.txt_NameFood.PasswordChar = '\0';
            this.txt_NameFood.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_NameFood.PlaceholderText = "";
            this.txt_NameFood.SelectedText = "";
            this.txt_NameFood.Size = new System.Drawing.Size(335, 30);
            this.txt_NameFood.TabIndex = 32;
            // 
            // lbl_NameFood
            // 
            this.lbl_NameFood.AutoSize = true;
            this.lbl_NameFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameFood.ForeColor = System.Drawing.Color.White;
            this.lbl_NameFood.Location = new System.Drawing.Point(13, 10);
            this.lbl_NameFood.Name = "lbl_NameFood";
            this.lbl_NameFood.Size = new System.Drawing.Size(100, 22);
            this.lbl_NameFood.TabIndex = 0;
            this.lbl_NameFood.Text = "Tên Món: ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txt_idFood);
            this.panel7.Controls.Add(this.lbl_FoodID);
            this.panel7.Location = new System.Drawing.Point(0, 39);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(531, 40);
            this.panel7.TabIndex = 2;
            // 
            // txt_idFood
            // 
            this.txt_idFood.Animated = true;
            this.txt_idFood.AutoRoundedCorners = true;
            this.txt_idFood.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txt_idFood.BorderRadius = 14;
            this.txt_idFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idFood.DefaultText = "";
            this.txt_idFood.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_idFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_idFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idFood.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txt_idFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_idFood.ForeColor = System.Drawing.Color.White;
            this.txt_idFood.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idFood.Location = new System.Drawing.Point(118, 0);
            this.txt_idFood.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idFood.Name = "txt_idFood";
            this.txt_idFood.PasswordChar = '\0';
            this.txt_idFood.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_idFood.PlaceholderText = "";
            this.txt_idFood.SelectedText = "";
            this.txt_idFood.Size = new System.Drawing.Size(335, 30);
            this.txt_idFood.TabIndex = 31;
            // 
            // lbl_FoodID
            // 
            this.lbl_FoodID.AutoSize = true;
            this.lbl_FoodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FoodID.ForeColor = System.Drawing.Color.White;
            this.lbl_FoodID.Location = new System.Drawing.Point(70, 8);
            this.lbl_FoodID.Name = "lbl_FoodID";
            this.lbl_FoodID.Size = new System.Drawing.Size(41, 22);
            this.lbl_FoodID.TabIndex = 0;
            this.lbl_FoodID.Text = "ID: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_LastFood);
            this.panel1.Controls.Add(this.btn_PrevioursFood);
            this.panel1.Controls.Add(this.btn_NextFood);
            this.panel1.Controls.Add(this.btn_FristFood);
            this.panel1.Location = new System.Drawing.Point(603, 527);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 53);
            this.panel1.TabIndex = 7;
            // 
            // btn_LastFood
            // 
            this.btn_LastFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btn_LastFood.FlatAppearance.BorderSize = 0;
            this.btn_LastFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LastFood.Image = ((System.Drawing.Image)(resources.GetObject("btn_LastFood.Image")));
            this.btn_LastFood.Location = new System.Drawing.Point(459, 15);
            this.btn_LastFood.Name = "btn_LastFood";
            this.btn_LastFood.Size = new System.Drawing.Size(75, 23);
            this.btn_LastFood.TabIndex = 28;
            this.btn_LastFood.UseVisualStyleBackColor = false;
            this.btn_LastFood.Click += new System.EventHandler(this.btn_LastFood_Click);
            // 
            // btn_PrevioursFood
            // 
            this.btn_PrevioursFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btn_PrevioursFood.FlatAppearance.BorderSize = 0;
            this.btn_PrevioursFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrevioursFood.Image = ((System.Drawing.Image)(resources.GetObject("btn_PrevioursFood.Image")));
            this.btn_PrevioursFood.Location = new System.Drawing.Point(153, 15);
            this.btn_PrevioursFood.Name = "btn_PrevioursFood";
            this.btn_PrevioursFood.Size = new System.Drawing.Size(75, 23);
            this.btn_PrevioursFood.TabIndex = 30;
            this.btn_PrevioursFood.UseVisualStyleBackColor = false;
            this.btn_PrevioursFood.Click += new System.EventHandler(this.btn_PrevioursFood_Click);
            // 
            // btn_NextFood
            // 
            this.btn_NextFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btn_NextFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_NextFood.BackgroundImage")));
            this.btn_NextFood.FlatAppearance.BorderSize = 0;
            this.btn_NextFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NextFood.Image = ((System.Drawing.Image)(resources.GetObject("btn_NextFood.Image")));
            this.btn_NextFood.Location = new System.Drawing.Point(301, 15);
            this.btn_NextFood.Name = "btn_NextFood";
            this.btn_NextFood.Size = new System.Drawing.Size(75, 23);
            this.btn_NextFood.TabIndex = 31;
            this.btn_NextFood.UseVisualStyleBackColor = false;
            this.btn_NextFood.Click += new System.EventHandler(this.btn_NextFood_Click);
            // 
            // btn_FristFood
            // 
            this.btn_FristFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btn_FristFood.FlatAppearance.BorderSize = 0;
            this.btn_FristFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FristFood.Image = ((System.Drawing.Image)(resources.GetObject("btn_FristFood.Image")));
            this.btn_FristFood.Location = new System.Drawing.Point(3, 15);
            this.btn_FristFood.Name = "btn_FristFood";
            this.btn_FristFood.Size = new System.Drawing.Size(75, 23);
            this.btn_FristFood.TabIndex = 29;
            this.btn_FristFood.UseVisualStyleBackColor = false;
            this.btn_FristFood.Click += new System.EventHandler(this.btn_FristFood_Click);
            // 
            // AdminFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1230, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dtgv_Food);
            this.Controls.Add(this.panel5);
            this.Name = "AdminFood";
            this.Text = "Thức Ăn";
            this.Load += new System.EventHandler(this.AdminFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Food)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_Food;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_ViewFood;
        private System.Windows.Forms.Button btn_EditFood;
        private System.Windows.Forms.Button btn_DeleteFood;
        private System.Windows.Forms.Button btn_AddFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_SearchFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbl_FoodPrice;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_NameFood;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_FoodID;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_NameFood;
        private Guna.UI2.WinForms.Guna2TextBox txt_idFood;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Category;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchFoodName;
        private System.Windows.Forms.Button btn_LastFood;
        private System.Windows.Forms.Button btn_NextFood;
        private System.Windows.Forms.Button btn_FristFood;
        private System.Windows.Forms.Button btn_PrevioursFood;
        private Guna.UI2.WinForms.Guna2TextBox txt_Price;
    }
}