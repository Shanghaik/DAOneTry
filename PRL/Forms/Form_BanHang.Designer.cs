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
            // Form_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 641);
            this.Controls.Add(this.lb_Page);
            this.Controls.Add(this.lbNext);
            this.Controls.Add(this.lb_Back);
            this.Controls.Add(this.tlp_Product);
            this.Name = "Form_BanHang";
            this.Text = "Form_BanHang";
            this.Load += new System.EventHandler(this.Form_BanHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tlp_Product;
        private Label lb_Back;
        private Label lbNext;
        private Label lb_Page;
    }
}