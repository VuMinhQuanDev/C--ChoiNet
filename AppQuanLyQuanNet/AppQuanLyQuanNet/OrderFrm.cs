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
    public partial class frmOrder : Form
    {


        public frmOrder()
        {
            InitializeComponent();
        }

        private SqlData sqlData = new SqlData();
        private string str = @"Data Source=LAPTOP-TJQ2IEGV\SQLEXPRESS;Initial Catalog=QLQuanNet;Persist Security Info=True;User ID=admin; Password=admin123";

        public DataTable getData(string cmd)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sqlData.Command(cmd, sqlData.connect()));
            DataTable dt = new DataTable();
            adp.Fill(dt);
            sqlData.Disconnect();
            return dt;
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
            
            sqlData.strConnect = str;
            
            comboBox1.DataSource = getData($"select loai from ThucAn group by loai");
            comboBox1.DisplayMember = "loai";
            comboBox1.ValueMember = "loai";

            comboBox2.DataSource = getData($"select tenMon from ThucAn");
            comboBox2.DisplayMember = "tenMon";
            comboBox2.ValueMember = "tenMon";

            comboBox3.DataSource = getData($"select loai from NuocUong group by loai");
            comboBox3.DisplayMember = "loai";
            comboBox3.ValueMember = "loai";

            comboBox4.DataSource = getData($"select tenMon from NuocUong");
            comboBox4.DisplayMember = "tenMon";
            comboBox4.ValueMember = "tenMon";

            txtName.Text = "";
            txtPrice.Text = "0";
            sqlData.Command($"delete from HoaDon", sqlData.connect()).ExecuteNonQuery();
            dataGridView1.DataSource = getData($"select tenTaiKhoan as 'Tên Tài Khoản', tenThucAn as 'Thức Ăn', tenNuocUong as 'Nước Uống', ngay as 'Ngày', tongTien as 'Tổng Tiền' from HoaDon");
        }

        private string RandomIndex()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = getData($"select tenMon from ThucAn where loai = N'{comboBox1.SelectedValue}'");
            comboBox2.DisplayMember = "tenMon";
            comboBox2.ValueMember = "tenMon";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPrice.Text = "0";
            sqlData.Command($"delete from HoaDon", sqlData.connect()).ExecuteNonQuery();
            dataGridView1.DataSource = getData($"select tenTaiKhoan as 'Tên Tài Khoản', tenThucAn as 'Thức Ăn', tenNuocUong as 'Nước Uống', ngay as 'Ngày', tongTien as 'Tổng Tiền' from HoaDon");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string today = DateTime.Today.ToString("MM-dd-yyyy");
            float tienDV = 0;
            tienDV = float.Parse(getData($"select gia from ThucAn where tenMon = N'{comboBox2.SelectedValue}'").Rows[0][0].ToString()) + float.Parse(getData($"select gia from NuocUong where tenMon = N'{comboBox4.SelectedValue}'").Rows[0][0].ToString());
            txtPrice.Text = (float.Parse(txtPrice.Text) + float.Parse(getData($"select gia from ThucAn where tenMon = N'{comboBox2.SelectedValue}'").Rows[0][0].ToString()) + float.Parse(getData($"select gia from NuocUong where tenMon = N'{comboBox4.SelectedValue}'").Rows[0][0].ToString())).ToString();
            sqlData.Command($"insert into HoaDon values ('{RandomIndex()}', N'{txtName.Text}', N'{comboBox2.SelectedValue}', N'{comboBox4.SelectedValue}' , '{DateTime.Today.ToString("MM/dd/yyyy")}', {tienDV})", sqlData.connect()).ExecuteNonQuery();
            dataGridView1.DataSource = getData($"select tenTaiKhoan as 'Tên Tài Khoản', tenThucAn as 'Thức Ăn', tenNuocUong as 'Nước Uống', ngay as 'Ngày', tongTien as 'Tổng Tiền' from HoaDon");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
