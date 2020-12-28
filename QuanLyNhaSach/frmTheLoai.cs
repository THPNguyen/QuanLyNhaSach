using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS_QLNS;
using ET_QLNS;
namespace QuanLyNhaSach
{
    public partial class frmTheLoai : Form
    {
        BUS_TheLoai bus_TheLoai = new BUS_TheLoai();
        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            dgvTheLoai.DataSource =  bus_TheLoai.GetData();
        }

        private void dgvTheLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(Keys.Enter  == (Keys)e.KeyChar)
            //{
            //    if (dgvTheLoai.CurrentRow.Selected)
            //    {
            //        DataGridViewRow row = dgvTheLoai.CurrentRow;

            //        string maTL = row.Cells[0].Value.ToString();
            //        string tenTL = row.Cells[1].Value.ToString();
            //        string maNCC = row.Cells[2].Value.ToString();
            //        ET_TheLoai et_TheLoai = new ET_TheLoai(maTL, tenTL, maNCC);
            //        if(bus_TheLoai.them(et_TheLoai))
            //        {
            //            dgvTheLoai.DataSource = bus_TheLoai.getData();
            //        }
            //    }
            //}
            
        }

        private void dgvTheLoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyData)
            {
                if (dgvTheLoai.CurrentRow.Selected)
                {
                    DataGridViewRow row = dgvTheLoai.CurrentRow;

                    string maTL = row.Cells[0].Value.ToString();
                    string tenTL = row.Cells[1].Value.ToString();
                    string maNCC = row.Cells[2].Value.ToString();
                    ET_TheLoai et_TheLoai = new ET_TheLoai(maTL, tenTL, maNCC);
                    if (bus_TheLoai.them(et_TheLoai))
                    {
                        dgvTheLoai.DataSource = bus_TheLoai.GetData();
                    }
                }
            }
        }
    }
}
