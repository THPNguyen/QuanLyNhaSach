using BUS_QLNS;
using ET_QLNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frmFuncBanSach : Form
    {
        public frmFuncBanSach()
        {
            InitializeComponent();
        }
        ET_Sach eT_Sach = new ET_Sach();
        BUS_ChiTietHoaDon bus_ChiTietHoaDon = new BUS_ChiTietHoaDon();
        BUS_Sach bus_Sach = new BUS_Sach();
        BUS_HoaDon bus_HoaDon = new BUS_HoaDon();
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();

        public void init()
        {
            
            cbNhanVien.DataSource = bus_NhanVien.GetData();
            cbNhanVien.DisplayMember = "TenNV";
            cbNhanVien.ValueMember = "MaNV";
            cbLoaiHoaDon.Items.Add("si");
            cbLoaiHoaDon.Items.Add("le");
            cbLoaiHoaDon.Text = "le";
            setDataGridview();
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.Text = "Demo";
            //btn.UseColumnTextForButtonValue = true;
            //dataGridView1.Columns.Add(btn);

            //dgvRow.Cells["dgvtxtThanhTien"].Value = String.Format("this is 0,0!");
            //dataGridView1.Rows[1].Cells[0].Value = String.Format("this is 0,0!");
        }

        public void setDataGridview()
        {
            DataGridViewRow dbTempt = dataGridView1.CurrentRow;
            dgvcbcSach.DataSource = bus_Sach.getSach();
            dgvcbcSach.DisplayMember = "TenSach";
            dgvcbcSach.ValueMember = "MaSach";
            Console.WriteLine("Ma sach: " + dgvcbcSach.DisplayMember);
        }

        public void outputMoney()
        {

        }

        private void frmFuncBanSach_Load(object sender, EventArgs e)
        {
            init();
        }

        private void cbSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GET value combobox
            //Console.WriteLine(cbSach.SelectedValue + "");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

    }
}
