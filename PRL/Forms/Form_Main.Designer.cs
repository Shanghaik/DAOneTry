namespace PRL.Forms
{
    partial class Form_Main
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
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Sell = new System.Windows.Forms.Button();
            this.btn_QLSP = new System.Windows.Forms.Button();
            this.btn_QLNV = new System.Windows.Forms.Button();
            this.btn_TK = new System.Windows.Forms.Button();
            this.lb_Account = new System.Windows.Forms.Label();
            this.pn_MainProgram = new System.Windows.Forms.Panel();
            this.btn_Sale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Home
            // 
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Home.Location = new System.Drawing.Point(12, 12);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(199, 82);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "Trang Chủ";
            this.btn_Home.UseVisualStyleBackColor = true;
            // 
            // btn_Sell
            // 
            this.btn_Sell.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sell.Location = new System.Drawing.Point(12, 98);
            this.btn_Sell.Name = "btn_Sell";
            this.btn_Sell.Size = new System.Drawing.Size(199, 81);
            this.btn_Sell.TabIndex = 1;
            this.btn_Sell.Text = "Bán hàng";
            this.btn_Sell.UseVisualStyleBackColor = true;
            this.btn_Sell.Click += new System.EventHandler(this.btn_Sell_Click);
            // 
            // btn_QLSP
            // 
            this.btn_QLSP.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QLSP.Location = new System.Drawing.Point(12, 186);
            this.btn_QLSP.Name = "btn_QLSP";
            this.btn_QLSP.Size = new System.Drawing.Size(199, 71);
            this.btn_QLSP.TabIndex = 2;
            this.btn_QLSP.Text = "Quản lý SP";
            this.btn_QLSP.UseVisualStyleBackColor = true;
            this.btn_QLSP.Click += new System.EventHandler(this.btn_QLSP_Click);
            // 
            // btn_QLNV
            // 
            this.btn_QLNV.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QLNV.Location = new System.Drawing.Point(13, 263);
            this.btn_QLNV.Name = "btn_QLNV";
            this.btn_QLNV.Size = new System.Drawing.Size(198, 75);
            this.btn_QLNV.TabIndex = 3;
            this.btn_QLNV.Text = "Quản lý NV";
            this.btn_QLNV.UseVisualStyleBackColor = true;
            this.btn_QLNV.Click += new System.EventHandler(this.btn_QLNV_Click);
            // 
            // btn_TK
            // 
            this.btn_TK.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TK.Location = new System.Drawing.Point(16, 344);
            this.btn_TK.Name = "btn_TK";
            this.btn_TK.Size = new System.Drawing.Size(195, 73);
            this.btn_TK.TabIndex = 4;
            this.btn_TK.Text = "Thống Kê";
            this.btn_TK.UseVisualStyleBackColor = true;
            // 
            // lb_Account
            // 
            this.lb_Account.AutoSize = true;
            this.lb_Account.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Account.Location = new System.Drawing.Point(16, 653);
            this.lb_Account.Name = "lb_Account";
            this.lb_Account.Size = new System.Drawing.Size(34, 31);
            this.lb_Account.TabIndex = 5;
            this.lb_Account.Text = "....";
            // 
            // pn_MainProgram
            // 
            this.pn_MainProgram.BackColor = System.Drawing.SystemColors.Info;
            this.pn_MainProgram.Location = new System.Drawing.Point(224, 16);
            this.pn_MainProgram.Name = "pn_MainProgram";
            this.pn_MainProgram.Size = new System.Drawing.Size(1376, 668);
            this.pn_MainProgram.TabIndex = 6;
            // 
            // btn_Sale
            // 
            this.btn_Sale.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sale.Location = new System.Drawing.Point(16, 423);
            this.btn_Sale.Name = "btn_Sale";
            this.btn_Sale.Size = new System.Drawing.Size(195, 70);
            this.btn_Sale.TabIndex = 7;
            this.btn_Sale.Text = "Quản lý sale";
            this.btn_Sale.UseVisualStyleBackColor = true;
            this.btn_Sale.Click += new System.EventHandler(this.btn_Sale_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 704);
            this.Controls.Add(this.btn_Sale);
            this.Controls.Add(this.pn_MainProgram);
            this.Controls.Add(this.lb_Account);
            this.Controls.Add(this.btn_TK);
            this.Controls.Add(this.btn_QLNV);
            this.Controls.Add(this.btn_QLSP);
            this.Controls.Add(this.btn_Sell);
            this.Controls.Add(this.btn_Home);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Home;
        private Button btn_Sell;
        private Button btn_QLSP;
        private Button btn_QLNV;
        private Button btn_TK;
        private Label lb_Account;
        private Panel pn_MainProgram;
        private Button btn_Sale;
    }
}