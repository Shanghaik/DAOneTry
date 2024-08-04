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
    }
}
