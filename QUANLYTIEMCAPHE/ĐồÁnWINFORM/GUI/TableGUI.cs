using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.Model;

namespace GUI
{
    public partial class TableGUI : Form
    {
        private CF_TableBLL tables = new CF_TableBLL();           
        public TableGUI()
        {
            InitializeComponent();    
            LoadTable();
            LoadAreas();
        }
        private void LoadTable()
        {
            dtgv_table.DataSource = tables.GetAllTables();
        }        

        private void LoadAreas()
        {
            var areas = new AreaDAL().GetAllAreas(); // Phương thức này tương tự như TableDAL
            cb_AreaID.DataSource = areas;
            cb_AreaID.DisplayMember = "AreaName";
            cb_AreaID.ValueMember = "AreaID";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                var table = new CF_Table
            {
                TableID = txt_TableID.Text,
                TableName = txt_TableName.Text,
                AreaID = cb_AreaID.SelectedValue.ToString(),
            };

            try
            {
                tables.AddTable(table); // Gọi BLL để thêm bàn
                LoadTable(); // Tải lại danh sách bàn
                MessageBox.Show("Thêm bàn thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            {
                var tableId = txt_TableID.Text;
                tables.DeleteTable(tableId);
                LoadTable();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var table = new CF_Table
            {
                TableID = txt_TableID.Text,
                TableName = txt_TableName.Text,
                AreaID = cb_AreaID.SelectedValue.ToString()
            };
            tables.UpdateTable(table);
            LoadTable();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_kluu_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgv_sinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gb_thongtin_Enter(object sender, EventArgs e)
        {

        }

        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_TableGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}

               
