using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppQuanLyQuanNet
{
    public partial class Loginfrm : Form
    {
        public Loginfrm()
        {
            InitializeComponent();
        }

        private SqlData sqlData = new SqlData();
        private string str = @"Data Source=LAPTOP-TJQ2IEGV\SQLEXPRESS;Initial Catalog=QLQuanNet;Persist Security Info=True;User ID=admin; Password=admin123";

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông Báo", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK) 
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sqlData.Command($"select count(*) as 'status' from AccountAdmin where tenTaiKhoan = N'{txtUserName.Text}' and matKhau = N'{txtPassword.Text}'", sqlData.connect()));
            DataTable tb = new DataTable();
            adp.Fill(tb);
            if(tb.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Option op = new Option();
                op.Show();
            }
            else
            {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Bị Sai! \n Vui Lòng Nhập Lại.", "Thông Báo");
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtUserName.Focus();
            }
        }

        private void Loginfrm_Load(object sender, EventArgs e)
        {
            sqlData.strConnect = str;
            txtUserName.Focus();
            //MessageBox.Show(DateTime.Today.ToString("MM/dd/yyyy"));
        }
    }
}
