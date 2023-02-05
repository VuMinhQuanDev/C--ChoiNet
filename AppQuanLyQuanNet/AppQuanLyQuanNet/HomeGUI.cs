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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private SqlData sqlData = new SqlData();
        private string str = @"Data Source=LAPTOP-TJQ2IEGV\SQLEXPRESS;Initial Catalog=QLQuanNet;Persist Security Info=True;User ID=admin; Password=admin123";
        private double totalMoney;
        public DataTable getData(string cmd)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sqlData.Command(cmd, sqlData.connect())); 
            DataTable dt = new DataTable();
            adp.Fill(dt);
            sqlData.Disconnect();
            return dt;
        }

        private double Price(TimeSpan t)
        {
            if(t.Minutes == 0 && t.Hours == 0)
            {
                return t.Seconds * 1.4;
            }
            else if(t.Hours == 0)
            {
                return t.Minutes * 60 * 1.4;
            }
            else
            {
                return (t.Hours * 3600 + t.Minutes * 60 + t.Seconds) * 1.4;
            }
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int indexRowSelected = dataComputer.SelectedCells[0].RowIndex;
            string valueRowSelected = dataComputer.Rows[indexRowSelected].Cells["Mã Máy"].Value.ToString();
            string status = dataComputer.Rows[indexRowSelected].Cells["Tình Trạng"].Value.ToString();

            if (status == "Tắt")
            {
                string now = DateTime.Now.ToString("HH:mm:ss");
                sqlData.Command($"update MayTram set tinhTrang = N'Hoạt Động', thoiGianBatDau = '{now}' where maMay = '{valueRowSelected}'", sqlData.connect()).ExecuteNonQuery();
                dataComputer.Rows[indexRowSelected].Cells["Bắt Đầu"].Value = now;
                dataComputer.Rows[indexRowSelected].Cells["Tình Trạng"].Value = "Hoạt Động";
            }
            else if (status == "Khóa")
            {
                MessageBox.Show("Máy Đang Bị Khóa!", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Máy Đang Được Mở!", "Thông Báo");
            }
        }

        private void openCom_MouseHover(object sender, EventArgs e)
        {
            Control c = sender as Control;
            c.Cursor = Cursors.Hand;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControls1.SelectedTab.Name.ToString())
            {
                case "tabComputer":
                    dataComputer.DataSource = getData("select maMay as 'Mã Máy', tenMay as 'Tên Máy', tinhTrang as 'Tình Trạng', thoiGianBatDau as 'Bắt Đầu', thoiGianKetThuc as 'Kết Thúc', tien as 'Tiền' from MayTram");
                    break;
                case "tabAcc":
                    dataAcc.DataSource = getData("select tenTaiKhoan as 'Tên Tài Khoản', matKhau as 'Mật Khẩu', maySuDung as 'Máy Đang Sử Dụng', soTienConLai as 'Số Tiền Còn Lại', thoiGianConLai as 'Thời Gian Còn Lại', trangThai as 'Trạng Thái' from TaiKhoan");
                    break;
                case "tabSystem":
                    dataSystem.DataSource = getData($"select maMay as 'Mã Máy', tenTaiKhoan as 'Người sử dụng', ngay as 'Ngày sử dụng', soTien as 'Số Tiền' from NhatKyHeThong");
                    break;
            }
        }

        private void delSystem_Click(object sender, EventArgs e)
        {
          
        }

        private void searchSystem_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            sqlData.strConnect = str;
            dataComputer.DataSource = getData("select maMay as 'Mã Máy', tenMay as 'Tên Máy', tinhTrang as 'Tình Trạng', thoiGianBatDau as 'Bắt Đầu', thoiGianKetThuc as 'Kết Thúc', tien as 'Tiền' from MayTram");
            dataAcc.DataSource = getData("select tenTaiKhoan as 'Tên Tài Khoản', matKhau as 'Mật Khẩu', maySuDung as 'Máy Đang Sử Dụng', soTienConLai as 'Số Tiền Còn Lại', thoiGianConLai as 'Thời Gian Còn Lại', trangThai as 'Trạng Thái' from TaiKhoan");
            dataSystem.DataSource = getData($"select maMay as 'Mã Máy', tenTaiKhoan as 'Người sử dụng', ngay as 'Ngày sử dụng', soTien as 'Số Tiền' from NhatKyHeThong");

            int rowLength = dataAcc.Rows.Count;
        }

        private void shutdown_Click(object sender, EventArgs e)
        {
            int indexRowSelected = dataComputer.SelectedCells[0].RowIndex;
            string valueRowSelected = dataComputer.Rows[indexRowSelected].Cells["Mã Máy"].Value.ToString();
            string status = dataComputer.Rows[indexRowSelected].Cells["Tình Trạng"].Value.ToString();
            if(status == "Hoạt Động")
            {
                // Cập Nhật Thời Gian Kết Thúc
                string now = DateTime.Now.ToString("HH:mm:ss");
                sqlData.Command($"update MayTram set tinhTrang = N'Tắt', thoiGianKetThuc = '{now}' where maMay = '{valueRowSelected}'", sqlData.connect()).ExecuteNonQuery();
                dataComputer.Rows[indexRowSelected].Cells["Kết Thúc"].Value = now;
                // End Code

                // Cập Nhật Giá Tiền
                DateTime startPrice = Convert.ToDateTime(dataComputer.Rows[indexRowSelected].Cells["Bắt Đầu"].Value.ToString());
                DateTime endPrice = Convert.ToDateTime(dataComputer.Rows[indexRowSelected].Cells["Kết Thúc"].Value.ToString());
                TimeSpan timePrice = endPrice - startPrice;
                sqlData.Command($"update MayTram set tien = {Price(timePrice)} where maMay = '{valueRowSelected}'", sqlData.connect()).ExecuteNonQuery();
                dataComputer.Rows[indexRowSelected].Cells["Tình Trạng"].Value = "Tắt";
                dataComputer.Rows[indexRowSelected].Cells["Tiền"].Value = Price(timePrice).ToString();
                totalMoney = Price(timePrice);
                // End Code
            }
            else if (status == "Khóa")
            {
                MessageBox.Show("Máy Đang Bị Khóa!", "Thông Báo");
            }else
            {
                MessageBox.Show("Máy Chưa Được Khởi Động!", "Thông Báo");
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void lockCom_Click(object sender, EventArgs e)
        {
            int indexRowSelected = dataComputer.SelectedCells[0].RowIndex;
            string valueRowSelected = dataComputer.Rows[indexRowSelected].Cells["Mã Máy"].Value.ToString();
            dataComputer.Rows[indexRowSelected].ReadOnly = true;
            if(label4.Text == "Khóa Máy")
            {
                DialogResult r = MessageBox.Show("Bạn có chắc muốn khóa máy không?", "Thông Báo", MessageBoxButtons.OKCancel);
                if(r == DialogResult.OK)
                {
                    sqlData.Command($"update MayTram set tinhTrang = N'Khóa' where maMay = '{valueRowSelected}'", sqlData.connect()).ExecuteNonQuery();
                    dataComputer.Rows[indexRowSelected].Cells["Tình Trạng"].Value = "Khóa";
                    label4.Text = "Mở Khóa";
                    lockCom.Image = Image.FromFile(@"D:\BTL C#\AppQuanLyQuanNet\AppQuanLyQuanNet\Resources\unlock.jpg");
                }
            }
            else
            {
                sqlData.Command($"update MayTram set tinhTrang = N'Tắt' where maMay = '{valueRowSelected}'", sqlData.connect()).ExecuteNonQuery();
                dataComputer.Rows[indexRowSelected].Cells["Tình Trạng"].Value = "Tắt";
                label4.Text = "Khóa Máy";
                lockCom.Image = Image.FromFile(@"D:\BTL C#\AppQuanLyQuanNet\AppQuanLyQuanNet\Resources\lock.jpg");
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            frmOrder frmOrder = new frmOrder();
            frmOrder.ShowDialog();
        }

        private void bill_Click(object sender, EventArgs e)
        {
            int indexRowSelected = dataComputer.SelectedCells[0].RowIndex;
            string valueRowSelected = dataComputer.Rows[indexRowSelected].Cells["Mã Máy"].Value.ToString();
            string status = dataComputer.Rows[indexRowSelected].Cells["Tình Trạng"].Value.ToString();
            DataTable leftMoneydt = getData($"select tien, soTienConLai, tenTaiKhoan from MayTram inner join TaiKhoan on maMay = TaiKhoan.maySuDung and maMay = '{valueRowSelected}'");
            float leftMoney = float.Parse(leftMoneydt.Rows[0][1].ToString()) - float.Parse(leftMoneydt.Rows[0][0].ToString());
            string nameAcc = leftMoneydt.Rows[0][2].ToString();
            if (status == "Hoạt Động") {
                MessageBox.Show("Máy Chưa Được Tắt!", "Thông Báo");
            }
            else if( status == "Khóa")
            {
                MessageBox.Show("Máy Đang Bị Khóa!", "Thông Báo");
            }else
            {
                sqlData.Command($"update MayTram set thoiGianBatDau = null, thoiGianKetThuc = null, tien = 0 where maMay = '{valueRowSelected}'", sqlData.connect()).ExecuteNonQuery();
                sqlData.Command($"update TaiKhoan set soTienConLai = {leftMoney}, maySuDung = null, trangThai='Off' where tenTaiKhoan = N'{nameAcc}'", sqlData.connect()).ExecuteNonQuery();
                dataComputer.Rows[indexRowSelected].Cells["Bắt Đầu"].Value = TimeSpan.Zero;
                dataComputer.Rows[indexRowSelected].Cells["Kết Thúc"].Value = TimeSpan.Zero;
                dataComputer.Rows[indexRowSelected].Cells["Tiền"].Value = 0;
                sqlData.Command($"insert into NhatKyHeThong values ('{RandomIndex()}', N'{valueRowSelected}', N'{nameAcc}', '{DateTime.Today.ToString("MM/dd/yyyy")}', {float.Parse(leftMoneydt.Rows[0][0].ToString())})",sqlData.connect()).ExecuteNonQuery();
            }

        }

        private void dataComputer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Option opt = new Option();
            DialogResult r = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if(r == DialogResult.Yes)
            {
                this.Hide();
                opt.Show();
            }
        }

        private void addAcc_Click(object sender, EventArgs e)
        {
            addMember addMemberFrm = new addMember();
            addMemberFrm.ShowDialog();
        }

        private void dataAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataComputer_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexRow = dataComputer.CurrentCell.RowIndex;
            string valueRowSelected = dataComputer.Rows[indexRow].Cells["Tình Trạng"].Value.ToString();
            if (valueRowSelected == "Khóa")
            {
                label4.Text = "Mở Khóa";
                lockCom.Image = Image.FromFile(@"D:\BTL C#\AppQuanLyQuanNet\AppQuanLyQuanNet\Resources\unlock.jpg");
            }
            else
            {
                lockCom.Image = Image.FromFile(@"D:\BTL C#\AppQuanLyQuanNet\AppQuanLyQuanNet\Resources\lock.jpg");
                label4.Text = "Khóa Máy";
            }
        }

        private void dtStartSystem_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void updateAcc_Click(object sender, EventArgs e)
        {
            dataAcc.DataSource = getData("select tenTaiKhoan as 'Tên Tài Khoản', matKhau as 'Mật Khẩu', maySuDung as 'Máy Đang Sử Dụng', soTienConLai as 'Số Tiền Còn Lại', thoiGianConLai as 'Thời Gian Còn Lại', trangThai as 'Trạng Thái' from TaiKhoan");
        }

        private void dataAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dataAcc.CurrentCell.RowIndex;
            addMemberTime addMemberTimeFrm = new addMemberTime();
            addMemberTimeFrm.nameAcc = dataAcc.Rows[indexRow].Cells["Tên Tài Khoản"].Value.ToString();
            addMemberTimeFrm.passAcc = dataAcc.Rows[indexRow].Cells["Mật Khẩu"].Value.ToString();
            addMemberTimeFrm.leftMoney = float.Parse(dataAcc.Rows[indexRow].Cells["Số Tiền Còn Lại"].Value.ToString());
            addMemberTimeFrm.ShowDialog();
        }

        private void delAcc_Click(object sender, EventArgs e)
        {
            int indexRow = dataAcc.CurrentCell.RowIndex;
            string nameAcc = dataAcc.Rows[indexRow].Cells["Tên Tài Khoản"].Value.ToString();
            DialogResult r = MessageBox.Show("Bạn Muốn Xóa Tài Khoản Này?", "Thông Báo", MessageBoxButtons.OKCancel);
            if(r == DialogResult.OK)
            {
                if(sqlData.Command($"delete from TaiKhoan where tenTaiKhoan = N'{nameAcc}'", sqlData.connect()).ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa Thành Công");
                    dataAcc.Rows.RemoveAt(indexRow);
                }else
                {
                    MessageBox.Show("Xóa Không Thành Công");
                }
            }
        }

        private void searchAcc_Click(object sender, EventArgs e)
        {
            dataAcc.DataSource = getData($"select tenTaiKhoan as 'Tên Tài Khoản', matKhau as 'Mật Khẩu', maySuDung as 'Máy Đang Sử Dụng', soTienConLai as 'Số Tiền Còn Lại', thoiGianConLai as 'Thời Gian Còn Lại', trangThai as 'Trạng Thái' from TaiKhoan where tenTaiKhoan = N'{txtSearchAcc.Text}'");
            txtSearchAcc.Clear();
        }

        private void dataSystem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tabControls1_TabIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(tabControls1.SelectedTab.Name.ToString());
        }
    }
}
