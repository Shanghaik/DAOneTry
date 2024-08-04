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
            }else if (accountInfor.Split(':')[0] == "0") // Cắt ra để lấy role, nếu = 0 tức là tài khoản đã bị khóa
            {
                MessageBox.Show("Tài khoản của bạn đã bị khóa, vui lòng kiểm tra xem đã bị đuổi việc chưa?");
            }
            else
            {
                Form_Main main = new Form_Main(accountInfor); // Tạo form main truyền account infor qua
                main.Show();
            }
        }
        private void cb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowPass.Checked)
            {
                tbt_Password.PasswordChar = '\0'; // Kí tự rỗng
            }
            else tbt_Password.PasswordChar = '*';
            
        }
    }
}
