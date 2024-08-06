using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class cpn_SP : Form
    {
        public cpn_SP()
        {
            InitializeComponent();
        }
        public Panel CreateSP(Product sp)
        {
            PictureBox ptb_Img = new System.Windows.Forms.PictureBox();
            Label tb_Name = new System.Windows.Forms.Label();
            Label lb_Gia = new System.Windows.Forms.Label();
            Label lb_SL = new System.Windows.Forms.Label();
            Label lb_Mota = new System.Windows.Forms.Label();
            Label lb_XuatXu = new System.Windows.Forms.Label();
            Label lb_GiaValue = new System.Windows.Forms.Label();
            Label lb_SLValue = new System.Windows.Forms.Label();
            Button btn_Mua = new System.Windows.Forms.Button();
            TextBox tbt_SLBan = new System.Windows.Forms.TextBox();   
            // 
            // ptb_Img
            // 
            ptb_Img.Location = new System.Drawing.Point(-1, 3);
            ptb_Img.Name = "ptb_Img";
            ptb_Img.Size = new System.Drawing.Size(143, 151);
            ptb_Img.TabIndex = 0;
            ptb_Img.TabStop = false;
            ptb_Img.ImageLocation = sp.ImgURL;
            // 
            // tb_Name
            // 
            tb_Name.AutoSize = true;
            tb_Name.Location = new System.Drawing.Point(148, 3);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new System.Drawing.Size(66, 20);
            tb_Name.TabIndex = 1;
            tb_Name.Text = sp.Name;
            // 
            // lb_Gia
            // 
            lb_Gia.AutoSize = true;
            lb_Gia.Location = new System.Drawing.Point(148, 32);
            lb_Gia.Name = "lb_Gia";
            lb_Gia.Size = new System.Drawing.Size(60, 20);
            lb_Gia.TabIndex = 2;
            lb_Gia.Text = "Giá bán";
            // 
            // lb_SL
            // 
            lb_SL.AutoSize = true;
            lb_SL.Location = new System.Drawing.Point(148, 98);
            lb_SL.Name = "lb_SL";
            lb_SL.Size = new System.Drawing.Size(69, 20);
            lb_SL.TabIndex = 3;
            lb_SL.Text = "Số lượng";
            // 
            // lb_Mota
            // 
            lb_Mota.AutoSize = true;
            lb_Mota.Location = new System.Drawing.Point(-1, 159);
            lb_Mota.Name = "lb_Mota";
            lb_Mota.Size = new System.Drawing.Size(138, 20);
            lb_Mota.TabIndex = 4;
            lb_Mota.Text = sp.Details;
            // 
            // lb_XuatXu
            // 
            lb_XuatXu.AutoSize = true;
            lb_XuatXu.Location = new System.Drawing.Point(1, 195);
            lb_XuatXu.Name = "lb_XuatXu";
            lb_XuatXu.Size = new System.Drawing.Size(137, 20);
            lb_XuatXu.TabIndex = 5;
            lb_XuatXu.Text = sp.From;
            // 
            // lb_GiaValue
            // 
            lb_GiaValue.AutoSize = true;
            lb_GiaValue.Location = new System.Drawing.Point(148, 64);
            lb_GiaValue.Name = "lb_GiaValue";
            lb_GiaValue.Size = new System.Drawing.Size(49, 20);
            lb_GiaValue.TabIndex = 2;
            lb_GiaValue.Text = sp.Price.ToString();
            // 
            // lb_SLValue
            // 
            lb_SLValue.AutoSize = true;
            lb_SLValue.Location = new System.Drawing.Point(148, 130);
            lb_SLValue.Name = "lb_SLValue";
            lb_SLValue.Size = new System.Drawing.Size(49, 20);
            lb_SLValue.TabIndex = 2;
            lb_SLValue.Text = sp.TotalAmount.ToString();
            // 
            // btn_Mua
            // 
            btn_Mua.Location = new System.Drawing.Point(148, 191);
            btn_Mua.Name = "btn_Mua";
            btn_Mua.Size = new System.Drawing.Size(122, 50);
            btn_Mua.TabIndex = 6;
            btn_Mua.Text = "Mua Hàng";
            btn_Mua.UseVisualStyleBackColor = true;
            // 
            // tbt_SLBan
            // 
            tbt_SLBan.Location = new System.Drawing.Point(148, 156);
            tbt_SLBan.Name = "tbt_SLBan";
            tbt_SLBan.PlaceholderText = "Nhập để mua";
            tbt_SLBan.Size = new System.Drawing.Size(122, 27);
            tbt_SLBan.TabIndex = 7;
            // 
            // cpn_SP
            // 
            Panel pn =  new Panel();
            pn.Size = new Size(300, 300);
            pn.Name = sp.Id.ToString();
            pn.Controls.Add(tbt_SLBan);
            pn.Controls.Add(btn_Mua);
            pn.Controls.Add(lb_XuatXu);
            pn.Controls.Add(lb_Mota);
            pn.Controls.Add(lb_SL);
            pn.Controls.Add(lb_SLValue);
            pn.Controls.Add(lb_GiaValue);
            pn.Controls.Add(lb_Gia);
            pn.Controls.Add(tb_Name);
            pn.Controls.Add(ptb_Img);
            return pn;
        }
    }
}
