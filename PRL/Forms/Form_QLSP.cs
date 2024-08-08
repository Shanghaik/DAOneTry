using DAL_BUS.BUS;
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
    public partial class Form_QLSP : Form
    {
        SaleServices _saleServices;
        ProductServices _services;
        List<Sale> activeSales;
        public Form_QLSP()
        {
            InitializeComponent();
            ptb_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            _services= new ProductServices();
            _saleServices = new SaleServices();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = tbt_Ten.Text,
                From = tbt_XuatXu.Text,
                Details = tbt_Mota.Text,
                Price = Convert.ToInt64(tbt_Price.Text),
                TotalAmount = Convert.ToInt32(tbt_Soluong.Text),
                Status = cbb_Status.SelectedIndex,
                ImgURL = ptb_Image.ImageLocation,
                SaleID = activeSales[cbb_Sale.SelectedIndex].Id // Vị trí của Sale trong list chính là vị trí của nó trong cbb
            };
            MessageBox.Show(_services.CreateProduct(product));
            LoadDataToGridView();
        }
        public void LoadDataToGridView()
        {
            dtg_Data.DataSource = null;
            var products = _services.GetAllProducts();
            dtg_Data.DataSource = products;
        }

        private void Form_QLSP_Load(object sender, EventArgs e)
        {
            activeSales = _saleServices.GetActiveSale(); /// danh sách các sale đang hoạt động
            foreach (var item in activeSales)
            {
                cbb_Sale.Items.Add(item.Name);
            }
            LoadDataToGridView();
        }

        private void ptb_Image_Click(object sender, EventArgs e) // Click vào để lấy ảnh
        {
            OpenFileDialog dialog= new OpenFileDialog();
            dialog.ShowDialog();
            ptb_Image.ImageLocation = dialog.FileName;
        }

        private void dtg_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_Data.Rows[e.RowIndex];
            tbt_Ten.Text = row.Cells[1].Value.ToString();
            tbt_Mota.Text = row.Cells[2].Value.ToString();
            ptb_Image.ImageLocation = row.Cells[3].Value.ToString();
            tbt_XuatXu.Text = row.Cells[4].Value.ToString();
            tbt_Price.Text = row.Cells[5].Value.ToString();
            tbt_Soluong.Text = row.Cells[6].Value.ToString();
           cbb_Status.SelectedIndex = Convert.ToInt32(row.Cells[7].Value);
        }
    }
}
