namespace PRL.Forms
{
    partial class FormVoucher
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
            this.tbt_Percent = new System.Windows.Forms.TextBox();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.tbt_Mota = new System.Windows.Forms.TextBox();
            this.tbt_Ten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.Location = new System.Drawing.Point(880, 264);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(262, 77);
            this.btn_Delete.TabIndex = 31;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Update.Location = new System.Drawing.Point(880, 137);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(262, 81);
            this.btn_Update.TabIndex = 30;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.Location = new System.Drawing.Point(879, 18);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(263, 80);
            this.btn_Add.TabIndex = 29;
            this.btn_Add.Text = "Thêm mới";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // dtg_Data
            // 
            this.dtg_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Data.Location = new System.Drawing.Point(30, 360);
            this.dtg_Data.Name = "dtg_Data";
            this.dtg_Data.RowHeadersWidth = 51;
            this.dtg_Data.RowTemplate.Height = 29;
            this.dtg_Data.Size = new System.Drawing.Size(764, 239);
            this.dtg_Data.TabIndex = 28;
            // 
            // cbb_Status
            // 
            this.cbb_Status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_Status.FormattingEnabled = true;
            this.cbb_Status.Items.AddRange(new object[] {
            "Hoạt động",
            "Không hoạt động"});
            this.cbb_Status.Location = new System.Drawing.Point(222, 292);
            this.cbb_Status.Name = "cbb_Status";
            this.cbb_Status.Size = new System.Drawing.Size(251, 36);
            this.cbb_Status.TabIndex = 27;
            // 
            // tbt_Percent
            // 
            this.tbt_Percent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_Percent.Location = new System.Drawing.Point(223, 236);
            this.tbt_Percent.Name = "tbt_Percent";
            this.tbt_Percent.Size = new System.Drawing.Size(125, 34);
            this.tbt_Percent.TabIndex = 26;
            // 
            // dtp_End
            // 
            this.dtp_End.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_End.Location = new System.Drawing.Point(223, 184);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(324, 34);
            this.dtp_End.TabIndex = 25;
            // 
            // dtp_Start
            // 
            this.dtp_Start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_Start.Location = new System.Drawing.Point(223, 121);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(324, 34);
            this.dtp_Start.TabIndex = 24;
            // 
            // tbt_Mota
            // 
            this.tbt_Mota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_Mota.Location = new System.Drawing.Point(224, 64);
            this.tbt_Mota.Name = "tbt_Mota";
            this.tbt_Mota.Size = new System.Drawing.Size(570, 34);
            this.tbt_Mota.TabIndex = 23;
            // 
            // tbt_Ten
            // 
            this.tbt_Ten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_Ten.Location = new System.Drawing.Point(224, 18);
            this.tbt_Ten.Name = "tbt_Ten";
            this.tbt_Ten.Size = new System.Drawing.Size(570, 34);
            this.tbt_Ten.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Giá trị giảm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mô tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên";
            // 
            // FormVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 641);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dtg_Data);
            this.Controls.Add(this.cbb_Status);
            this.Controls.Add(this.tbt_Percent);
            this.Controls.Add(this.dtp_End);
            this.Controls.Add(this.dtp_Start);
            this.Controls.Add(this.tbt_Mota);
            this.Controls.Add(this.tbt_Ten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVoucher";
            this.Text = "FormVoucher";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_Add;
        private DataGridView dtg_Data;
        private ComboBox cbb_Status;
        private TextBox tbt_Percent;
        private DateTimePicker dtp_End;
        private DateTimePicker dtp_Start;
        private TextBox tbt_Mota;
        private TextBox tbt_Ten;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}