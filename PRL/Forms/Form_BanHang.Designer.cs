namespace PRL.Forms
{
    partial class Form_BanHang
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
            this.tlp_Product = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Back = new System.Windows.Forms.Label();
            this.lbNext = new System.Windows.Forms.Label();
            this.lb_Page = new System.Windows.Forms.Label();
            this.dtg_HD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_Phone = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_Voucher = new System.Windows.Forms.ComboBox();
            this.lb_MaHD = new System.Windows.Forms.Label();
            this.lb_money = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtg_HDCT = new System.Windows.Forms.DataGridView();
            this.tbt_Phone = new System.Windows.Forms.TextBox();
            this.tbt_Name = new System.Windows.Forms.TextBox();
            this.btn_CreateBill = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HDCT)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Product
            // 
            this.tlp_Product.ColumnCount = 2;
            this.tlp_Product.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Product.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Product.Location = new System.Drawing.Point(4, 3);
            this.tlp_Product.Name = "tlp_Product";
            this.tlp_Product.RowCount = 2;
            this.tlp_Product.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Product.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Product.Size = new System.Drawing.Size(600, 600);
            this.tlp_Product.TabIndex = 0;
            // 
            // lb_Back
            // 
            this.lb_Back.AutoSize = true;
            this.lb_Back.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_Back.Location = new System.Drawing.Point(204, 603);
            this.lb_Back.Name = "lb_Back";
            this.lb_Back.Size = new System.Drawing.Size(54, 28);
            this.lb_Back.TabIndex = 1;
            this.lb_Back.Text = "<<<";
            this.lb_Back.Click += new System.EventHandler(this.lb_Back_Click);
            // 
            // lbNext
            // 
            this.lbNext.AutoSize = true;
            this.lbNext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbNext.Location = new System.Drawing.Point(379, 603);
            this.lbNext.Name = "lbNext";
            this.lbNext.Size = new System.Drawing.Size(54, 28);
            this.lbNext.TabIndex = 2;
            this.lbNext.Text = ">>>";
            this.lbNext.Click += new System.EventHandler(this.lbNext_Click);
            // 
            // lb_Page
            // 
            this.lb_Page.AutoSize = true;
            this.lb_Page.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_Page.Location = new System.Drawing.Point(293, 603);
            this.lb_Page.Name = "lb_Page";
            this.lb_Page.Size = new System.Drawing.Size(20, 28);
            this.lb_Page.TabIndex = 3;
            this.lb_Page.Text = "1";
            // 
            // dtg_HD
            // 
            this.dtg_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_HD.Location = new System.Drawing.Point(617, 193);
            this.dtg_HD.Name = "dtg_HD";
            this.dtg_HD.RowHeadersWidth = 51;
            this.dtg_HD.RowTemplate.Height = 29;
            this.dtg_HD.Size = new System.Drawing.Size(721, 162);
            this.dtg_HD.TabIndex = 4;
            this.dtg_HD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_HD_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(622, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(622, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "SDT Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(622, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Voucher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(622, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng tiền";
            // 
            // cbb_Phone
            // 
            this.cbb_Phone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbb_Phone.FormattingEnabled = true;
            this.cbb_Phone.Location = new System.Drawing.Point(1047, 42);
            this.cbb_Phone.Name = "cbb_Phone";
            this.cbb_Phone.Size = new System.Drawing.Size(291, 33);
            this.cbb_Phone.TabIndex = 8;
            this.cbb_Phone.TextChanged += new System.EventHandler(this.cbb_Phone_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(622, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên Khách hàng";
            // 
            // cbb_Voucher
            // 
            this.cbb_Voucher.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbb_Voucher.FormattingEnabled = true;
            this.cbb_Voucher.Location = new System.Drawing.Point(790, 120);
            this.cbb_Voucher.Name = "cbb_Voucher";
            this.cbb_Voucher.Size = new System.Drawing.Size(548, 33);
            this.cbb_Voucher.TabIndex = 10;
            // 
            // lb_MaHD
            // 
            this.lb_MaHD.AutoSize = true;
            this.lb_MaHD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_MaHD.Location = new System.Drawing.Point(791, 7);
            this.lb_MaHD.Name = "lb_MaHD";
            this.lb_MaHD.Size = new System.Drawing.Size(48, 25);
            this.lb_MaHD.TabIndex = 11;
            this.lb_MaHD.Text = "HDX";
            // 
            // lb_money
            // 
            this.lb_money.AutoSize = true;
            this.lb_money.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_money.Location = new System.Drawing.Point(789, 162);
            this.lb_money.Name = "lb_money";
            this.lb_money.Size = new System.Drawing.Size(48, 25);
            this.lb_money.TabIndex = 12;
            this.lb_money.Text = "xxxx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(617, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Danh sách sản phẩm trong Hóa đơn";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dtg_HDCT
            // 
            this.dtg_HDCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_HDCT.Location = new System.Drawing.Point(620, 407);
            this.dtg_HDCT.Name = "dtg_HDCT";
            this.dtg_HDCT.RowHeadersWidth = 51;
            this.dtg_HDCT.RowTemplate.Height = 29;
            this.dtg_HDCT.Size = new System.Drawing.Size(718, 224);
            this.dtg_HDCT.TabIndex = 13;
            // 
            // tbt_Phone
            // 
            this.tbt_Phone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Phone.Location = new System.Drawing.Point(791, 45);
            this.tbt_Phone.Name = "tbt_Phone";
            this.tbt_Phone.PlaceholderText = "Nhập SDT";
            this.tbt_Phone.Size = new System.Drawing.Size(223, 31);
            this.tbt_Phone.TabIndex = 14;
            this.tbt_Phone.TextChanged += new System.EventHandler(this.tbt_Phone_TextChanged);
            // 
            // tbt_Name
            // 
            this.tbt_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Name.Location = new System.Drawing.Point(791, 83);
            this.tbt_Name.Name = "tbt_Name";
            this.tbt_Name.PlaceholderText = "Tên khách";
            this.tbt_Name.Size = new System.Drawing.Size(547, 31);
            this.tbt_Name.TabIndex = 15;
            // 
            // btn_CreateBill
            // 
            this.btn_CreateBill.BackColor = System.Drawing.Color.Yellow;
            this.btn_CreateBill.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CreateBill.Location = new System.Drawing.Point(1126, 3);
            this.btn_CreateBill.Name = "btn_CreateBill";
            this.btn_CreateBill.Size = new System.Drawing.Size(212, 34);
            this.btn_CreateBill.TabIndex = 16;
            this.btn_CreateBill.Text = "Thêm mới 1 Hóa đơn";
            this.btn_CreateBill.UseVisualStyleBackColor = false;
            this.btn_CreateBill.Click += new System.EventHandler(this.createBill_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThanhToan.Location = new System.Drawing.Point(1075, 361);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(263, 38);
            this.btn_ThanhToan.TabIndex = 17;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            // 
            // Form_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 641);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_CreateBill);
            this.Controls.Add(this.tbt_Name);
            this.Controls.Add(this.tbt_Phone);
            this.Controls.Add(this.dtg_HDCT);
            this.Controls.Add(this.lb_money);
            this.Controls.Add(this.lb_MaHD);
            this.Controls.Add(this.cbb_Voucher);
            this.Controls.Add(this.cbb_Phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_HD);
            this.Controls.Add(this.lb_Page);
            this.Controls.Add(this.lbNext);
            this.Controls.Add(this.lb_Back);
            this.Controls.Add(this.tlp_Product);
            this.Name = "Form_BanHang";
            this.Text = "Form_BanHang";
            this.Load += new System.EventHandler(this.Form_BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HDCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tlp_Product;
        private Label lb_Back;
        private Label lbNext;
        private Label lb_Page;
        private DataGridView dtg_HD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbb_Phone;
        private Label label5;
        private ComboBox cbb_Voucher;
        private Label lb_MaHD;
        private Label lb_money;
        private Label label6;
        private DataGridView dtg_HDCT;
        private TextBox tbt_Phone;
        private TextBox tbt_Name;
        private Button btn_CreateBill;
        private Button btn_ThanhToan;
    }
}