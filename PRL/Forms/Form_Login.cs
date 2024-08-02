using DAL_BUS.BUS;
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
    public partial class Form_Login : Form
    {
        AccountServices _accountService;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            _accountService = new AccountServices();
            string username = tbt_Username.Text;
            string password = tbt_Password.Text;
            string accountInfor = _accountService.Login(username, password);
            if (string.IsNullOrEmpty(accountInfor))
            {
                MessageBox.Show("Đăng nhập thất bại");
            }else
            {
                Form_Main main = new Form_Main(accountInfor); // Tạo form main truyền account infor qua
                main.Show();
            }
        }
    }
}
