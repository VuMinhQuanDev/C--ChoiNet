namespace AppQuanLyQuanNet
{
    partial class addMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbComputer = new System.Windows.Forms.ComboBox();
            this.mayTramBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLQuanNetDataSet3 = new AppQuanLyQuanNet.QLQuanNetDataSet3();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExtraMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LeftMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qLQuanNetDataSet2 = new AppQuanLyQuanNet.QLQuanNetDataSet2();
            this.mayTramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mayTramTableAdapter = new AppQuanLyQuanNet.QLQuanNetDataSet2TableAdapters.MayTramTableAdapter();
            this.mayTramTableAdapter1 = new AppQuanLyQuanNet.QLQuanNetDataSet3TableAdapters.MayTramTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mayTramBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQuanNetDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQuanNetDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mayTramBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAccountPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAccountName);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài Khoản";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Image = global::AppQuanLyQuanNet.Properties.Resources.btnCancel_Image;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(295, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 43);
            this.button2.TabIndex = 15;
            this.button2.Text = "Hủy bỏ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::AppQuanLyQuanNet.Properties.Resources.btnOK_Image;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(20, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Đồng Ý";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbComputer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ExtraMoney);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.LeftMoney);
            this.groupBox2.Location = new System.Drawing.Point(20, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 169);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản Lý nạp giờ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbComputer
            // 
            this.cbComputer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComputer.Location = new System.Drawing.Point(254, 119);
            this.cbComputer.Name = "cbComputer";
            this.cbComputer.Size = new System.Drawing.Size(121, 24);
            this.cbComputer.TabIndex = 11;
            this.cbComputer.SelectedIndexChanged += new System.EventHandler(this.cbComputer_SelectedIndexChanged);
            // 
            // mayTramBindingSource1
            // 
            this.mayTramBindingSource1.DataMember = "MayTram";
            this.mayTramBindingSource1.DataSource = this.qLQuanNetDataSet3;
            // 
            // qLQuanNetDataSet3
            // 
            this.qLQuanNetDataSet3.DataSetName = "QLQuanNetDataSet3";
            this.qLQuanNetDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Máy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tiền Nạp Thêm";
            // 
            // ExtraMoney
            // 
            this.ExtraMoney.Location = new System.Drawing.Point(142, 72);
            this.ExtraMoney.Name = "ExtraMoney";
            this.ExtraMoney.Size = new System.Drawing.Size(233, 22);
            this.ExtraMoney.TabIndex = 8;
            this.ExtraMoney.TextChanged += new System.EventHandler(this.ExtraMoney_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tiền Hiện Còn";
            // 
            // LeftMoney
            // 
            this.LeftMoney.Cursor = System.Windows.Forms.Cursors.No;
            this.LeftMoney.Location = new System.Drawing.Point(142, 21);
            this.LeftMoney.Name = "LeftMoney";
            this.LeftMoney.ReadOnly = true;
            this.LeftMoney.Size = new System.Drawing.Size(233, 22);
            this.LeftMoney.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật Khẩu";
            // 
            // txtAccountPassword
            // 
            this.txtAccountPassword.Location = new System.Drawing.Point(189, 125);
            this.txtAccountPassword.Name = "txtAccountPassword";
            this.txtAccountPassword.Size = new System.Drawing.Size(233, 22);
            this.txtAccountPassword.TabIndex = 4;
            this.txtAccountPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(189, 52);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(233, 22);
            this.txtAccountName.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppQuanLyQuanNet.Properties.Resources.pictureBox2_2_Image;
            this.pictureBox2.Location = new System.Drawing.Point(20, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppQuanLyQuanNet.Properties.Resources.pictureBox1_Image;
            this.pictureBox1.Location = new System.Drawing.Point(20, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // qLQuanNetDataSet2
            // 
            this.qLQuanNetDataSet2.DataSetName = "QLQuanNetDataSet2";
            this.qLQuanNetDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mayTramBindingSource
            // 
            this.mayTramBindingSource.DataMember = "MayTram";
            this.mayTramBindingSource.DataSource = this.qLQuanNetDataSet2;
            // 
            // mayTramTableAdapter
            // 
            this.mayTramTableAdapter.ClearBeforeFill = true;
            // 
            // mayTramTableAdapter1
            // 
            this.mayTramTableAdapter1.ClearBeforeFill = true;
            // 
            // addMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 524);
            this.Controls.Add(this.groupBox1);
            this.Name = "addMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Tài Khoản";
            this.Load += new System.EventHandler(this.addMember_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mayTramBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQuanNetDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQuanNetDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mayTramBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbComputer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExtraMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LeftMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private QLQuanNetDataSet2 qLQuanNetDataSet2;
        private System.Windows.Forms.BindingSource mayTramBindingSource;
        private QLQuanNetDataSet2TableAdapters.MayTramTableAdapter mayTramTableAdapter;
        private QLQuanNetDataSet3 qLQuanNetDataSet3;
        private System.Windows.Forms.BindingSource mayTramBindingSource1;
        private QLQuanNetDataSet3TableAdapters.MayTramTableAdapter mayTramTableAdapter1;
    }
}