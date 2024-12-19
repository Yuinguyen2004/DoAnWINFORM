namespace GUI
{
    public partial class TableGUI
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
            this.gb_thongtin = new System.Windows.Forms.GroupBox();
            this.cb_AreaID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TableName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TableID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoát = new System.Windows.Forms.Button();
            this.dtgv_table = new System.Windows.Forms.DataGridView();
            this.gb_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_table)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_thongtin
            // 
            this.gb_thongtin.Controls.Add(this.cb_AreaID);
            this.gb_thongtin.Controls.Add(this.label4);
            this.gb_thongtin.Controls.Add(this.txt_TableName);
            this.gb_thongtin.Controls.Add(this.label3);
            this.gb_thongtin.Controls.Add(this.txt_TableID);
            this.gb_thongtin.Controls.Add(this.label1);
            this.gb_thongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_thongtin.Location = new System.Drawing.Point(55, 5);
            this.gb_thongtin.Name = "gb_thongtin";
            this.gb_thongtin.Size = new System.Drawing.Size(709, 151);
            this.gb_thongtin.TabIndex = 0;
            this.gb_thongtin.TabStop = false;
            this.gb_thongtin.Text = "Thông tin chi tiết";
            this.gb_thongtin.Enter += new System.EventHandler(this.gb_thongtin_Enter);
            // 
            // cb_AreaID
            // 
            this.cb_AreaID.FormattingEnabled = true;
            this.cb_AreaID.Items.AddRange(new object[] {
            "1",
            "2",
            ""});
            this.cb_AreaID.Location = new System.Drawing.Point(164, 77);
            this.cb_AreaID.Name = "cb_AreaID";
            this.cb_AreaID.Size = new System.Drawing.Size(140, 28);
            this.cb_AreaID.TabIndex = 5;
            this.cb_AreaID.SelectedIndexChanged += new System.EventHandler(this.cb_lop_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Khu vực:";
            // 
            // txt_TableName
            // 
            this.txt_TableName.Location = new System.Drawing.Point(502, 39);
            this.txt_TableName.Multiline = true;
            this.txt_TableName.Name = "txt_TableName";
            this.txt_TableName.Size = new System.Drawing.Size(167, 22);
            this.txt_TableName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên bàn:";
            // 
            // txt_TableID
            // 
            this.txt_TableID.Location = new System.Drawing.Point(164, 37);
            this.txt_TableID.Multiline = true;
            this.txt_TableID.Name = "txt_TableID";
            this.txt_TableID.Size = new System.Drawing.Size(163, 22);
            this.txt_TableID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bàn:";
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(12, 162);
            this.txt_tim.Multiline = true;
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(140, 36);
            this.txt_tim.TabIndex = 2;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(168, 162);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 36);
            this.btn_tim.TabIndex = 3;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(270, 174);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(64, 24);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(355, 174);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(64, 24);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Tag = "";
            this.btn_xoa.Text = "xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(441, 174);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(64, 24);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_thoát
            // 
            this.btn_thoát.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoát.Location = new System.Drawing.Point(700, 174);
            this.btn_thoát.Name = "btn_thoát";
            this.btn_thoát.Size = new System.Drawing.Size(64, 24);
            this.btn_thoát.TabIndex = 9;
            this.btn_thoát.Text = "thoát";
            this.btn_thoát.UseVisualStyleBackColor = true;
            // 
            // dtgv_table
            // 
            this.dtgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_table.Location = new System.Drawing.Point(55, 204);
            this.dtgv_table.Name = "dtgv_table";
            this.dtgv_table.RowHeadersWidth = 51;
            this.dtgv_table.RowTemplate.Height = 24;
            this.dtgv_table.Size = new System.Drawing.Size(709, 234);
            this.dtgv_table.TabIndex = 10;
            this.dtgv_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_sinhvien_CellContentClick);
            // 
            // TableGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_thoát;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgv_table);
            this.Controls.Add(this.btn_thoát);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.gb_thongtin);
            this.Name = "TableGUI";
            this.Text = "Quản lý sản phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_TableGUI_FormClosing);
            this.gb_thongtin.ResumeLayout(false);
            this.gb_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_thongtin;
        private System.Windows.Forms.TextBox txt_TableID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_AreaID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TableName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_thoát;
        private System.Windows.Forms.DataGridView dtgv_table;
    }
}

