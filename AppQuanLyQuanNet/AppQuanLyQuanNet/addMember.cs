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
    public partial class addMember : Form
    {

        public addMember()
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void addMember_Load(object sender, EventArgs e)
        {
            sqlData.strConnect = str;
            cbComputer.DataSource = getData("select * from MayTram where tinhTrang = N'Tắt'");
            cbComputer.DisplayMember = "tenMay";
            cbComputer.ValueMember = "maMay";
        }

        private void ExtraMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account newAcc = new Account();
            newAcc.Name = txtAccountName.Text;
            newAcc.Password = txtAccountPassword.Text;
            newAcc.usingCom = cbComputer.SelectedValue.ToString();
            newAcc.money = float.Parse(ExtraMoney.Text);
            newAcc.time = newAcc.getTime(newAcc.money);
            newAcc.status = "On";
            if(sqlData.Command($"insert into TaiKhoan values (N'{newAcc.Name}', N'{newAcc.Password}', '{newAcc.usingCom}', {newAcc.money}, '{newAcc.time}', '{newAcc.status}')", sqlData.connect()).ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm Thành Công");
            }else
            {
                MessageBox.Show("Thêm Không Thành Công");
            }

            this.Close();
        }

        private void cbComputer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
