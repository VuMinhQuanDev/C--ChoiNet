using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyQuanNet
{
    public partial class addMemberTime : Form
    {
        public addMemberTime()
        {
            InitializeComponent();
        }

        private SqlData sqlData = new SqlData();
        private string str = @"Data Source=LAPTOP-TJQ2IEGV\SQLEXPRESS;Initial Catalog=QLQuanNet;Persist Security Info=True;User ID=admin; Password=admin123";

        public string nameAcc;
        public string passAcc;
        public float leftMoney;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addMemberTime_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLQuanNetDataSet8.MayTram' table. You can move, or remove it, as needed.
            this.mayTramTableAdapter.Fill(this.qLQuanNetDataSet8.MayTram);
            sqlData.strConnect = str;
            textBox1.Text = nameAcc.ToString();
            textBox2.Text = passAcc.ToString();
            textBox4.Text = leftMoney.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float extraMoney;
            if(textBox3.Text.ToString() == "")
            {
                extraMoney = 0;
            }else
            {
                extraMoney = float.Parse(textBox3.Text.ToString());
            }
            float total = leftMoney + extraMoney;
            Account account = new Account();
            sqlData.Command($"update TaiKhoan set soTienConLai = '{total}', thoiGianConLai = '{account.getTime(total)}', maySuDung = N'{cbComputer.SelectedValue.ToString()}', trangThai = 'On' where tenTaiKhoan = N'{nameAcc}'", sqlData.connect()).ExecuteNonQuery();
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
