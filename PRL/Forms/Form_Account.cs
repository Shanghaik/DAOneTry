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
    public partial class Form_Account : Form
    {
        AccountServices _services;
        public Form_Account()
        {
            _services= new AccountServices();
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string username = tbt_Username.Text;
            string password = tbt_Password.Text;
            int role = cbb_Role.SelectedIndex; // Selected index mặc định là -1
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || role == -1) {
                MessageBox.Show("Dữ liệu sai, hãy kiểm tra lại");
            }else
            {
                // DialogResult là kết quả cho một hộp thoại chứa câu hỏi Yes/No/Cancel,...
                DialogResult result = MessageBox.Show("Bạn muốn thêm chứ?", "Thêm tài khoản", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    string message = _services.CreateAccount(username, password, role);
                    MessageBox.Show(message);
                    LoadDataToGridView();
                }
            }
        }

        private void Form_Account_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
        public void LoadDataToGridView()
        {
            dtg_Data.DataSource = null;
            var data = _services.GetAccounts();
            dtg_Data.DataSource = data;
        }

        private void dtg_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_Data.Rows[e.RowIndex];
            tbt_Username.Text = row.Cells[0].Value.ToString();
            tbt_Password.Text = row.Cells[1].Value.ToString();
            cbb_Role.SelectedIndex = Convert.ToInt32(row.Cells[2].Value);   
        }

        private void btn_Khoa_Click(object sender, EventArgs e)
        {
            string username = tbt_Username.Text;
            string message = _services.LockAccount(username);
            MessageBox.Show(message);
            LoadDataToGridView();
        }

        private void btn_MoKhoa_Click(object sender, EventArgs e)
        {
            string username = tbt_Username.Text;
            string message = _services.UnLockAccount(username);
            MessageBox.Show(message);
            LoadDataToGridView();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string username = tbt_Username.Text;
            string password = tbt_Password.Text;
            int role = cbb_Role.SelectedIndex; // Selected index mặc định là -1
            MessageBox.Show(_services.UpdateAccount(username, password, role));
            LoadDataToGridView();
        }
    }
}
