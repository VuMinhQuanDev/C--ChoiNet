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
    public partial class Order : Form
    {
        public Order()
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
            return dt;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            foodObject food = new foodObject();
            food.nameFood = namefood.Text;
            food.foodType = food.getFoodType(food.nameFood);
            if(food.foodType != "")
            {
                food.priceFood = Convert.ToDouble(pricefood.Text.ToString());
            }
            food.foodUnit = unitfood.Text;
            if (food.foodUnit != "")
            {
                food.amountFood = Convert.ToInt32(amountfood.Text);
            }else
            {
                food.amountFood = 0;
            }
            if(sqlData.Command($"insert into ThucAn values (N'{food.nameFood}', N'{food.foodType}', {food.priceFood}, N'{food.foodUnit}', {food.amountFood})", sqlData.connect()).ExecuteNonQuery() > 0){
                MessageBox.Show("Thêm Thành Công!", "Thông Báo");
            }else
            {
                MessageBox.Show("Thêm Không Thành Công!", "Thông Báo");
            }
            datafood.DataSource = getData("select tenMon as 'Tên Món Ăn', loai as 'Loại', gia as 'Đơn Giá', donvi as 'Đơn Vị', soLuongTon as 'Số Lượng Tồn' from ThucAn");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void exitfood_Click(object sender, EventArgs e)
        {
            Option opt = new Option();
            DialogResult r = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                this.Hide();
                opt.Show();
            }
        }

        private void datafood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {
            sqlData.strConnect = str;

            datafood.DataSource = getData("select tenMon as 'Tên Món Ăn', loai as 'Loại', gia as 'Đơn Giá', donvi as 'Đơn Vị', soLuongTon as 'Số Lượng Tồn' from ThucAn");
            datadrink.DataSource = getData("select tenMon as 'Tên Món Ăn', loai as 'Loại', gia as 'Đơn Giá', donvi as 'Đơn Vị', soLuongTon as 'Số Lượng Tồn' from NuocUong");
            
        }

        private void updatefood_Click(object sender, EventArgs e)
        {
            
        }

        private void datafood_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexRow = datafood.CurrentCell.RowIndex;
            namefood.Text = datafood.Rows[indexRow].Cells["Tên Món Ăn"].Value.ToString();
            pricefood.Text = datafood.Rows[indexRow].Cells["Đơn Giá"].Value.ToString();
            unitfood.Text = datafood.Rows[indexRow].Cells["Đơn Vị"].Value.ToString();
            amountfood.Text = datafood.Rows[indexRow].Cells["Số Lượng Tồn"].Value.ToString();
        }
    }
}
