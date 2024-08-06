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
    public partial class Form_Sale : Form
    {
        SaleServices _sevice;
        public Form_Sale()
        {
            InitializeComponent();
            _sevice = new SaleServices();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale()
            {
                Id = Guid.NewGuid(),
                Name = tbt_Ten.Text,
                Description = tbt_Mota.Text,
                StartDate = dtp_Start.Value,
                EndDate = dtp_End.Value,
                Percent = Convert.ToDouble(tbt_Percent.Text),
                Status = cbb_Status.SelectedIndex
            };
            MessageBox.Show(_sevice.CreateSales(sale));
            LoadAllSale();
        }
        public void LoadAllSale()
        {
            dtg_Data.DataSource = null;
            var allSale = _sevice.GetAllSales();
            dtg_Data.DataSource = allSale;
        }

        private void Form_Sale_Load(object sender, EventArgs e)
        {
            LoadAllSale();
        }
    }
}
