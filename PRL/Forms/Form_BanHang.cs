using DAL_BUS.BUS;
using DAL_BUS.DAL;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using PRL.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class Form_BanHang : Form
    {
        CustomerServices _customerServices;
        ProductServices _productServices;
        SaleServices _saleServices;
        BillServices _billServices;
        BillDetailsServices _billDetailsService;
        List<Product> _products;
        List<Customer> _customers;
        public Form_BanHang()
        {
            InitializeComponent();
            _productServices = new ProductServices();
        }
        public Panel CreateSP(SaleProduct sp)
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
            Label lb_GiaMoi = new System.Windows.Forms.Label();
            // 
            // ptb_Img
            // 
            ptb_Img.Location = new System.Drawing.Point(-1, 3);
            ptb_Img.Name = "ptb_Img";
            ptb_Img.Size = new System.Drawing.Size(143, 151);
            ptb_Img.TabIndex = 0;
            ptb_Img.TabStop = false;
            ptb_Img.ImageLocation = sp.ImgURL;
            ptb_Img.SizeMode = PictureBoxSizeMode.StretchImage;
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
            lb_GiaValue.Location = new System.Drawing.Point(148, 77);
            lb_GiaValue.Name = "lb_GiaValue";
            lb_GiaValue.Size = new System.Drawing.Size(100, 20);
            lb_GiaValue.TabIndex = 2;
            lb_GiaValue.Text = sp.Price.ToString();
            lb_GiaValue.Font = new Font(lb_XuatXu.Font, FontStyle.Strikeout);
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
            // Tạo sự kiện để mua hàng
            btn_Mua.Click += Btn_Mua_Click;
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
            // lb_GiaMoi
            // 
            lb_GiaMoi.AutoSize = true;
            lb_GiaMoi.Location = new System.Drawing.Point(148, 57);
            lb_GiaMoi.Name = "lb_GiaMoi";
            lb_GiaMoi.Size = new System.Drawing.Size(49, 20);
            lb_GiaMoi.TabIndex = 2;
            lb_GiaMoi.Text = sp.SalePrice.ToString();
            // 
            // 
            Panel pn = new Panel();
            pn.Name = sp.Id.ToString(); // gán tên cho Panel để lưu ID cho sản phâm
            pn.Size = new Size(300, 300);

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
            pn.Controls.Add(lb_GiaMoi);
            return pn;
        }

        private void Btn_Mua_Click(object? sender, EventArgs e)
        {
            long price = 0;
            int amount = 0;
            // Lấy thông tin của panel chứa SP
            Button btnMua = sender as Button;
            Panel cpnSP = btnMua.Parent as Panel;
            // Lấy danh sách Label trong Panel ra
            List<Label> labels = new List<Label>();
            List<TextBox> textboxs = new List<TextBox>();
            foreach (var item in cpnSP.Controls)
            {
                if (item is Label) labels.Add(item as Label);
                if (item is TextBox) textboxs.Add(item as TextBox);
            }
            foreach (var item in labels)
            {
                if (item.Name == "lb_GiaMoi")
                {
                    price = Convert.ToInt64(item.Text); break;
                }
            }
            foreach (var item in textboxs)
            {
                if (item.Name == "tbt_SLBan")
                {
                    amount = Convert.ToInt32(item.Text); break;
                }
            }
            // Lấy các thuộc tính vần thiết
            Guid productId = Guid.Parse(cpnSP.Name);
            Guid billId = Guid.Parse(lb_MaHD.Text);
            _billDetailsService = new BillDetailsServices();
            _billDetailsService.AddToBill(billId, productId, price, amount);
            LoadBillDetails(Guid.Parse(lb_MaHD.Text));
        }

        public void LoadBillDetails(Guid billId)
        {
            _billDetailsService = new BillDetailsServices();
            var billDetails = _billDetailsService.GetAllByBillId(billId);
            dtg_HDCT.DataSource = null;
            dtg_HDCT.DataSource = billDetails;
        }

        public void LoadProductByPage(int page) // Load sản phẩm theo trang, mỗi trang 4 sp
        {
            tlp_Product.Controls.Clear();
            _products = _productServices.GetAllProducts(); // Lấy ra tất cả SP
            _saleServices = new SaleServices();
            var sales = _saleServices.GetAllSales();
            // Join để lấy data
            var saleProducts =
                from product in _products
                join sale in sales
                on product.SaleID equals sale.Id
                select new SaleProduct
                {
                    Id = product.Id,
                    Name = product.Name,
                    Details = product.Details,
                    ImgURL = product.ImgURL,
                    From = product.From,
                    Price = product.Price,
                    TotalAmount = product.TotalAmount,
                    Status = product.Status,
                    SalePrice = Convert.ToInt64(product.Price - product.Price * (sale.Percent / 100))
                };
            // Khi có danh sách sản phẩm ta kiểm tra xem page có vi phạm không
            if (page * 4 - 4 < saleProducts.ToList().Count)
            {
                SaleProduct sp = saleProducts.ToList()[page * 4 - 4];
                Panel p1 = CreateSP(sp);
                tlp_Product.Controls.Add(p1, 0, 0);
            }
            if (page * 4 - 3 < saleProducts.ToList().Count)
            {
                SaleProduct sp = saleProducts.ToList()[page * 4 - 3];
                Panel p2 = CreateSP(sp);
                tlp_Product.Controls.Add(p2, 0, 1);
            }
            if (page * 4 - 2 < saleProducts.ToList().Count)
            {
                SaleProduct sp = saleProducts.ToList()[page * 4 - 2];
                Panel p3 = CreateSP(sp);
                tlp_Product.Controls.Add(p3, 1, 0);
            }
            if (page * 4 - 1 < saleProducts.ToList().Count)
            {
                SaleProduct sp = saleProducts.ToList()[page * 4 - 1];
                Panel p4 = CreateSP(sp);
                tlp_Product.Controls.Add(p4, 1, 1);
            }
            // Để xử lý Join không ra kết quả chúng ta có thể tạo 1 bản ghi sale 0% cho những cái nào ko sale
        }

        private void Form_BanHang_Load(object sender, EventArgs e)
        {
            LoadProductByPage(1);
            LoadBill();
        }

        private void lbNext_Click(object sender, EventArgs e)
        {
            var products = _productServices.GetAllProducts();
            int count = products.Count;
            if (Convert.ToInt32(lb_Page.Text) < count / 4 && count % 4 == 0
                || Convert.ToInt32(lb_Page.Text) <= count / 4 && count % 4 != 0)
            {
                lb_Page.Text = Convert.ToInt32(lb_Page.Text) + 1 + "";
                LoadProductByPage(Convert.ToInt32(lb_Page.Text));
            }
        }

        private void lb_Back_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_Page.Text) >= 2)
            {
                lb_Page.Text = Convert.ToInt32(lb_Page.Text) - 1 + "";
                LoadProductByPage(Convert.ToInt32(lb_Page.Text));
            }

        }



        private void cbb_Phone_TextChanged(object sender, EventArgs e)
        {
            int index = cbb_Phone.SelectedIndex;
            tbt_Name.Text = _customers[index].Name + "-" + _customers[index].PhoneNumber;
        }

        private void tbt_Phone_TextChanged(object sender, EventArgs e)
        {
            cbb_Phone.Items.Clear();
            _customerServices = new CustomerServices();
            string searchPhone = tbt_Phone.Text;
            _customers = _customerServices.GetByPhone(searchPhone); // tìm kiếm và hiện ra khi cần
            foreach (var item in _customers)
            {
                cbb_Phone.Items.Add(item.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void createBill_Click(object sender, EventArgs e)
        {
            string accountId = "";
            var formMain = this.Parent.Parent as Form; // Lấy từ form Cha là form Main
            // this là formBanHang cho nên Parent của nó là Panel, Parent của panel mới là form Main
            List<Label> labels = new List<Label>();
            foreach (var item in formMain.Controls)
            {
                if (item is Label) labels.Add((Label)item);
            }
            // Lấy hết label từ form cha
            foreach (var item in labels)
            {
                if (item.Name == "lb_Account")
                {
                    accountId = item.Text; break;
                }
            } // từ các label mình lấy ra label nào có tên là Account ID để thông qua đó lấy ID
            _billServices = new BillServices();
            _billServices.Create(accountId, cbb_Phone.Text);
            LoadBill();
        }
        public void LoadBill()
        {
            dtg_HD.DataSource = null;
            _billServices = new BillServices();
            var bills = _billServices.GetWaitBill();
            dtg_HD.DataSource = bills;
        }

        private void dtg_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_HD.Rows[e.RowIndex];
            lb_MaHD.Text = row.Cells[0].Value.ToString();
            LoadBillDetails(Guid.Parse(row.Cells[0].Value.ToString()));
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
