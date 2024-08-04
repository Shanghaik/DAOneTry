namespace PRL.Forms
{
    partial class Form_Account
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
            this.dtg_Data = new System.Windows.Forms.DataGridView();
            this.tbt_Username = new System.Windows.Forms.TextBox();
            this.tbt_Password = new System.Windows.Forms.TextBox();
            this.cbb_Role = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Khoa = new System.Windows.Forms.Button();
            this.btn_MoKhoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Data
            // 
            this.dtg_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Data.Location = new System.Drawing.Point(12, 295);
            this.dtg_Data.Name = "dtg_Data";
            this.dtg_Data.RowHeadersWidth = 51;
            this.dtg_Data.RowTemplate.Height = 29;
            this.dtg_Data.Size = new System.Drawing.Size(1334, 314);
            this.dtg_Data.TabIndex = 0;
            this.dtg_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Data_CellClick);
            // 
            // tbt_Username
            // 
            this.tbt_Username.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Username.Location = new System.Drawing.Point(260, 22);
            this.tbt_Username.Name = "tbt_Username";
            this.tbt_Username.Size = new System.Drawing.Size(987, 38);
            this.tbt_Username.TabIndex = 1;
            // 
            // tbt_Password
            // 
            this.tbt_Password.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Password.Location = new System.Drawing.Point(260, 79);
            this.tbt_Password.Name = "tbt_Password";
            this.tbt_Password.Size = new System.Drawing.Size(985, 38);
            this.tbt_Password.TabIndex = 2;
            // 
            // cbb_Role
            // 
            this.cbb_Role.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbb_Role.FormattingEnabled = true;
            this.cbb_Role.Items.AddRange(new object[] {
            "Tài khoản bị khóa",
            "Admin",
            "Nhân viên"});
            this.cbb_Role.Location = new System.Drawing.Point(260, 133);
            this.cbb_Role.Name = "cbb_Role";
            this.cbb_Role.Size = new System.Drawing.Size(435, 39);
            this.cbb_Role.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Role";
            // 
            // btn_Them
            // 
            this.btn_Them.BackgroundImage = global::PRL.Properties.Resources.Them;
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Them.Location = new System.Drawing.Point(14, 195);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(86, 81);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackgroundImage = global::PRL.Properties.Resources.Sua;
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sua.Location = new System.Drawing.Point(125, 195);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(87, 81);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Khoa
            // 
            this.btn_Khoa.BackgroundImage = global::PRL.Properties.Resources.Khoa;
            this.btn_Khoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Khoa.Location = new System.Drawing.Point(240, 195);
            this.btn_Khoa.Name = "btn_Khoa";
            this.btn_Khoa.Size = new System.Drawing.Size(87, 81);
            this.btn_Khoa.TabIndex = 9;
            this.btn_Khoa.UseVisualStyleBackColor = true;
            this.btn_Khoa.Click += new System.EventHandler(this.btn_Khoa_Click);
            // 
            // btn_MoKhoa
            // 
            this.btn_MoKhoa.BackgroundImage = global::PRL.Properties.Resources.Mokhoa;
            this.btn_MoKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_MoKhoa.Location = new System.Drawing.Point(361, 195);
            this.btn_MoKhoa.Name = "btn_MoKhoa";
            this.btn_MoKhoa.Size = new System.Drawing.Size(81, 81);
            this.btn_MoKhoa.TabIndex = 10;
            this.btn_MoKhoa.UseVisualStyleBackColor = true;
            this.btn_MoKhoa.Click += new System.EventHandler(this.btn_MoKhoa_Click);
            // 
            // Form_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1358, 621);
            this.Controls.Add(this.btn_MoKhoa);
            this.Controls.Add(this.btn_Khoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_Role);
            this.Controls.Add(this.tbt_Password);
            this.Controls.Add(this.tbt_Username);
            this.Controls.Add(this.dtg_Data);
            this.Name = "Form_Account";
            this.Text = "Form_Account";
            this.Load += new System.EventHandler(this.Form_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtg_Data;
        private TextBox tbt_Username;
        private TextBox tbt_Password;
        private ComboBox cbb_Role;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Khoa;
        private Button btn_MoKhoa;
    }
}