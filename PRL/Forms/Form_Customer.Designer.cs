namespace PRL.Forms
{
    partial class Form_Customer
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
            this.btn_MoKhoa = new System.Windows.Forms.Button();
            this.btn_Khoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbt_Name = new System.Windows.Forms.TextBox();
            this.tbt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.dtg_Data = new System.Windows.Forms.DataGridView();
            this.tbt_Point = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_MoKhoa
            // 
            this.btn_MoKhoa.BackgroundImage = global::PRL.Properties.Resources.Mokhoa;
            this.btn_MoKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_MoKhoa.Location = new System.Drawing.Point(357, 200);
            this.btn_MoKhoa.Name = "btn_MoKhoa";
            this.btn_MoKhoa.Size = new System.Drawing.Size(81, 81);
            this.btn_MoKhoa.TabIndex = 21;
            this.btn_MoKhoa.UseVisualStyleBackColor = true;
            // 
            // btn_Khoa
            // 
            this.btn_Khoa.BackgroundImage = global::PRL.Properties.Resources.Khoa;
            this.btn_Khoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Khoa.Location = new System.Drawing.Point(236, 200);
            this.btn_Khoa.Name = "btn_Khoa";
            this.btn_Khoa.Size = new System.Drawing.Size(87, 81);
            this.btn_Khoa.TabIndex = 20;
            this.btn_Khoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackgroundImage = global::PRL.Properties.Resources.Sua;
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sua.Location = new System.Drawing.Point(121, 200);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(87, 81);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.BackgroundImage = global::PRL.Properties.Resources.Them;
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Them.Location = new System.Drawing.Point(10, 200);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(86, 81);
            this.btn_Them.TabIndex = 18;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Phone Number";
            // 
            // tbt_Name
            // 
            this.tbt_Name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Name.Location = new System.Drawing.Point(256, 84);
            this.tbt_Name.Name = "tbt_Name";
            this.tbt_Name.Size = new System.Drawing.Size(985, 38);
            this.tbt_Name.TabIndex = 13;
            // 
            // tbt_PhoneNumber
            // 
            this.tbt_PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_PhoneNumber.Location = new System.Drawing.Point(256, 27);
            this.tbt_PhoneNumber.Name = "tbt_PhoneNumber";
            this.tbt_PhoneNumber.Size = new System.Drawing.Size(987, 38);
            this.tbt_PhoneNumber.TabIndex = 12;
            // 
            // dtg_Data
            // 
            this.dtg_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Data.Location = new System.Drawing.Point(8, 300);
            this.dtg_Data.Name = "dtg_Data";
            this.dtg_Data.RowHeadersWidth = 51;
            this.dtg_Data.RowTemplate.Height = 29;
            this.dtg_Data.Size = new System.Drawing.Size(1334, 314);
            this.dtg_Data.TabIndex = 11;
            // 
            // tbt_Point
            // 
            this.tbt_Point.Location = new System.Drawing.Point(256, 142);
            this.tbt_Point.Name = "tbt_Point";
            this.tbt_Point.Size = new System.Drawing.Size(198, 27);
            this.tbt_Point.TabIndex = 22;
            // 
            // Form_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 641);
            this.Controls.Add(this.tbt_Point);
            this.Controls.Add(this.btn_MoKhoa);
            this.Controls.Add(this.btn_Khoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbt_Name);
            this.Controls.Add(this.tbt_PhoneNumber);
            this.Controls.Add(this.dtg_Data);
            this.Name = "Form_Customer";
            this.Text = "Form_Customer";
            this.Load += new System.EventHandler(this.Form_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_MoKhoa;
        private Button btn_Khoa;
        private Button btn_Sua;
        private Button btn_Them;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbt_Name;
        private TextBox tbt_PhoneNumber;
        private DataGridView dtg_Data;
        private TextBox tbt_Point;
    }
}