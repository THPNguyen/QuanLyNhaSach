using BUS_QLNS;
using ET_QLNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class ControlBanSach : UserControl
    {
        ET_Sach eT_Sach = new ET_Sach();
        BUS_ChiTietHoaDon bus_ChiTietHoaDon = new BUS_ChiTietHoaDon();
        BUS_Sach bus_Sach = new BUS_Sach();
        BUS_HoaDon bus_HoaDon = new BUS_HoaDon();
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();

        public void Init()
        {
            cbNhanVien.DataSource = bus_NhanVien.GetData();
            cbNhanVien.DisplayMember = "TenNV";
            cbNhanVien.ValueMember = "MaNV";
            cbLoaiHoaDon.Items.Add("Sỉ");
            cbLoaiHoaDon.Items.Add("Lẻ");
            cbLoaiHoaDon.Text = "Lẻ";
            SetDataGridview();
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.Text = "Demo";
            //btn.UseColumnTextForButtonValue = true;
            //dataGridView1.Columns.Add(btn);

            //dgvRow.Cells["dgvtxtThanhTien"].Value = String.Format("this is 0,0!");
            //dataGridView1.Rows[1].Cells[0].Value = String.Format("this is 0,0!");
        }

        public void MoneyForEachProduct()
        {
            
        }

        public void SetDataGridview()
        {
            DataGridViewRow dbTempt = dataGridView1.CurrentRow;
            dgvcbcSach.DataSource = bus_Sach.getSach();
            dgvcbcSach.DisplayMember = "TenSach";
            dgvcbcSach.ValueMember = "MaSach";
            Console.WriteLine("Ma sach: " + dgvcbcSach.DisplayMember);
        }

        public ControlBanSach()
        {
            InitializeComponent();
            Init();

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Console.WriteLine("Size: " + dataGridView1.CurrentRow.Index);
                int index = dataGridView1.CurrentRow.Index;
                DataGridViewRow dgvRow = dataGridView1.CurrentRow;
                
                if (dgvRow.Cells["dgvtxtSoLuong"].Value != null && dgvRow.Cells["dgvcbcSach"].Value != null)
                {
                    Console.WriteLine("Value: " + Convert.ToString(dgvRow.Cells["dgvcbcSach"].Value));
                    dataGridView1.Rows[index].Cells["dgvtxtThanhTien"].Value =
                        Convert.ToInt32(dgvRow.Cells["dgvtxtSoLuong"].Value) * bus_Sach.getGiaSach(Convert.ToString(dgvRow.Cells["dgvcbcSach"].Value));
                }
            }
        }
    }
}
