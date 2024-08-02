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
        public Form_Main(string accountInfo)
        {
            InitializeComponent();
            this.accountInfor = accountInfo;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            string[] infor = accountInfor.Split(':'); // Cắt role và username ra để xử lý
            lb_Account.Text = infor[1];
            if (infor[0] == "2")
            {
                btn_QLNV.Visible = false;
                btn_QLSP.Visible = false;
                btn_TK.Visible = false;
            }
        }
    }
}
