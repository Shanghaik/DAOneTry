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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_Phone = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_Name = new System.Windows.Forms.Label();
            this.cbb_Voucher = new System.Windows.Forms.ComboBox();
            this.lb_MaHD = new System.Windows.Forms.Label();
            this.lb_money = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(635, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(680, 106);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(640, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Hóa đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(640, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "SDT Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(640, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Voucher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(640, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng tiền";
            // 
            // cbb_Phone
            // 
            this.cbb_Phone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbb_Phone.FormattingEnabled = true;
            this.cbb_Phone.Location = new System.Drawing.Point(807, 42);
            this.cbb_Phone.Name = "cbb_Phone";
            this.cbb_Phone.Size = new System.Drawing.Size(508, 33);
            this.cbb_Phone.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(640, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên Khách hàng";
            // 
            // cbb_Name
            // 
            this.cbb_Name.AutoSize = true;
            this.cbb_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbb_Name.Location = new System.Drawing.Point(807, 85);
            this.cbb_Name.Name = "cbb_Name";
            this.cbb_Name.Size = new System.Drawing.Size(83, 25);
            this.cbb_Name.TabIndex = 9;
            this.cbb_Name.Text = "Lê Văn X";
            // 
            // cbb_Voucher
            // 
            this.cbb_Voucher.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbb_Voucher.FormattingEnabled = true;
            this.cbb_Voucher.Location = new System.Drawing.Point(808, 118);
            this.cbb_Voucher.Name = "cbb_Voucher";
            this.cbb_Voucher.Size = new System.Drawing.Size(507, 33);
            this.cbb_Voucher.TabIndex = 10;
            // 
            // lb_MaHD
            // 
            this.lb_MaHD.AutoSize = true;
            this.lb_MaHD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_MaHD.Location = new System.Drawing.Point(809, 7);
            this.lb_MaHD.Name = "lb_MaHD";
            this.lb_MaHD.Size = new System.Drawing.Size(48, 25);
            this.lb_MaHD.TabIndex = 11;
            this.lb_MaHD.Text = "HDX";
            // 
            // lb_money
            // 
            this.lb_money.AutoSize = true;
            this.lb_money.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_money.Location = new System.Drawing.Point(807, 162);
            this.lb_money.Name = "lb_money";
            this.lb_money.Size = new System.Drawing.Size(48, 25);
            this.lb_money.TabIndex = 12;
            this.lb_money.Text = "xxxx";
            // 
            // Form_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 641);
            this.Controls.Add(this.lb_money);
            this.Controls.Add(this.lb_MaHD);
            this.Controls.Add(this.cbb_Voucher);
            this.Controls.Add(this.cbb_Name);
            this.Controls.Add(this.cbb_Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_Page);
            this.Controls.Add(this.lbNext);
            this.Controls.Add(this.lb_Back);
            this.Controls.Add(this.tlp_Product);
            this.Name = "Form_BanHang";
            this.Text = "Form_BanHang";
            this.Load += new System.EventHandler(this.Form_BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tlp_Product;
        private Label lb_Back;
        private Label lbNext;
        private Label lb_Page;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbb_Phone;
        private Label label5;
        private Label cbb_Name;
        private ComboBox cbb_Voucher;
        private Label lb_MaHD;
        private Label lb_money;
    }
}