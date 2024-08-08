namespace PRL.Forms
{
    partial class Form_QLSP
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dtg_Data = new System.Windows.Forms.DataGridView();
            this.cbb_Status = new System.Windows.Forms.ComboBox();
            this.tbt_Price = new System.Windows.Forms.TextBox();
            this.tbt_Mota = new System.Windows.Forms.TextBox();
            this.tbt_Ten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptb_Image = new System.Windows.Forms.PictureBox();
            this.tbt_XuatXu = new System.Windows.Forms.TextBox();
            this.tbt_Soluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_Sale = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.Location = new System.Drawing.Point(866, 513);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(182, 77);
            this.btn_Delete.TabIndex = 31;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Update.Location = new System.Drawing.Point(866, 426);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(182, 81);
            this.btn_Update.TabIndex = 30;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.Location = new System.Drawing.Point(866, 340);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(183, 80);
            this.btn_Add.TabIndex = 29;
            this.btn_Add.Text = "Thêm mới";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dtg_Data
            // 
            this.dtg_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Data.Location = new System.Drawing.Point(15, 357);
            this.dtg_Data.Name = "dtg_Data";
            this.dtg_Data.RowHeadersWidth = 51;
            this.dtg_Data.RowTemplate.Height = 29;
            this.dtg_Data.Size = new System.Drawing.Size(764, 239);
            this.dtg_Data.TabIndex = 28;
            this.dtg_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Data_CellClick);
            // 
            // cbb_Status
            // 
            this.cbb_Status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_Status.FormattingEnabled = true;
            this.cbb_Status.Items.AddRange(new object[] {
            "Hoạt động",
            "Không hoạt động"});
            this.cbb_Status.Location = new System.Drawing.Point(207, 289);
            this.cbb_Status.Name = "cbb_Status";
            this.cbb_Status.Size = new System.Drawing.Size(102, 36);
            this.cbb_Status.TabIndex = 27;
            // 
            // tbt_Price
            // 
            this.tbt_Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_Price.Location = new System.Drawing.Point(208, 233);
            this.tbt_Price.Name = "tbt_Price";
            this.tbt_Price.Size = new System.Drawing.Size(571, 34);
            this.tbt_Price.TabIndex = 26;
            // 
            // tbt_Mota
            // 
            this.tbt_Mota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_Mota.Location = new System.Drawing.Point(209, 61);
            this.tbt_Mota.Name = "tbt_Mota";
            this.tbt_Mota.Size = new System.Drawing.Size(570, 34);
            this.tbt_Mota.TabIndex = 23;
            // 
            // tbt_Ten
            // 
            this.tbt_Ten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_Ten.Location = new System.Drawing.Point(209, 15);
            this.tbt_Ten.Name = "tbt_Ten";
            this.tbt_Ten.Size = new System.Drawing.Size(570, 34);
            this.tbt_Ten.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Giá bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số lượng còn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Xuất xứ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mô tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên";
            // 
            // ptb_Image
            // 
            this.ptb_Image.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ptb_Image.Location = new System.Drawing.Point(866, 17);
            this.ptb_Image.Name = "ptb_Image";
            this.ptb_Image.Size = new System.Drawing.Size(310, 298);
            this.ptb_Image.TabIndex = 32;
            this.ptb_Image.TabStop = false;
            this.ptb_Image.Click += new System.EventHandler(this.ptb_Image_Click);
            // 
            // tbt_XuatXu
            // 
            this.tbt_XuatXu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_XuatXu.Location = new System.Drawing.Point(209, 124);
            this.tbt_XuatXu.Name = "tbt_XuatXu";
            this.tbt_XuatXu.Size = new System.Drawing.Size(570, 34);
            this.tbt_XuatXu.TabIndex = 33;
            // 
            // tbt_Soluong
            // 
            this.tbt_Soluong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_Soluong.Location = new System.Drawing.Point(208, 184);
            this.tbt_Soluong.Name = "tbt_Soluong";
            this.tbt_Soluong.Size = new System.Drawing.Size(571, 34);
            this.tbt_Soluong.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(357, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sale";
            // 
            // cbb_Sale
            // 
            this.cbb_Sale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_Sale.FormattingEnabled = true;
            this.cbb_Sale.Location = new System.Drawing.Point(450, 289);
            this.cbb_Sale.Name = "cbb_Sale";
            this.cbb_Sale.Size = new System.Drawing.Size(329, 36);
            this.cbb_Sale.TabIndex = 35;
            // 
            // Form_QLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 621);
            this.Controls.Add(this.cbb_Sale);
            this.Controls.Add(this.tbt_Soluong);
            this.Controls.Add(this.tbt_XuatXu);
            this.Controls.Add(this.ptb_Image);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dtg_Data);
            this.Controls.Add(this.cbb_Status);
            this.Controls.Add(this.tbt_Price);
            this.Controls.Add(this.tbt_Mota);
            this.Controls.Add(this.tbt_Ten);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_QLSP";
            this.Text = "Form_QLSP";
            this.Load += new System.EventHandler(this.Form_QLSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_Add;
        private DataGridView dtg_Data;
        private ComboBox cbb_Status;
        private TextBox tbt_Price;
        private TextBox tbt_Mota;
        private TextBox tbt_Ten;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox ptb_Image;
        private TextBox tbt_XuatXu;
        private TextBox tbt_Soluong;
        private Label label7;
        private ComboBox cbb_Sale;
    }
}