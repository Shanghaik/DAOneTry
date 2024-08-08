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
    public partial class Form_Main : Form
    {
        string accountInfor; // Biến này tạo ra để lưu thông tin luên quan tới account và quyền (role)
        public Form_Main(string accountInfo) // Constructor 
        {
            InitializeComponent();
            this.accountInfor = accountInfo;
        }
        // Role:Account
        private void Form_Main_Load(object sender, EventArgs e)
        {
            string[] infor = accountInfor.Split(':'); // Cắt role và username ra để xử lý
            lb_Account.Text = infor[1];
            if (infor[0] == "2") // Nếu role == 2 tức là nhân viên thì không hiển thị các nút quản lý
            {
                btn_QLNV.Visible = false;
                btn_QLSP.Visible = false;
                btn_TK.Visible = false;
            }
        }

        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            pn_MainProgram.Controls.Clear();
            Form_Account form_Account = new Form_Account();
            form_Account.TopLevel = false;
            pn_MainProgram.Controls.Add(form_Account);
            form_Account.FormBorderStyle = FormBorderStyle.None;
            form_Account.Show();
        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            pn_MainProgram.Controls.Clear();
            Form_Sale form_Sale = new Form_Sale();
            form_Sale.TopLevel = false;
            pn_MainProgram.Controls.Add(form_Sale);
            form_Sale.FormBorderStyle = FormBorderStyle.None;
            form_Sale.Show();
        }

        private void btn_QLSP_Click(object sender, EventArgs e)
        {
            pn_MainProgram.Controls.Clear();
            Form_QLSP form_QLSP = new Form_QLSP();
            form_QLSP.TopLevel = false;
            pn_MainProgram.Controls.Add(form_QLSP);
            form_QLSP.FormBorderStyle = FormBorderStyle.None;
            form_QLSP.Show();
        }

        private void btn_Sell_Click(object sender, EventArgs e)
        {
            pn_MainProgram.Controls.Clear();
            Form_BanHang form_BanHang= new Form_BanHang();
            form_BanHang.TopLevel = false;
            pn_MainProgram.Controls.Add(form_BanHang);
            form_BanHang.FormBorderStyle = FormBorderStyle.None;
            form_BanHang.Show();
        }
    }
}
