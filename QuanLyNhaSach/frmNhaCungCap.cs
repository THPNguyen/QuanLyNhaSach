using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS_QLNS;

namespace QuanLyNhaSach
{
    public partial class frmNhaCungCap : Form
    {
        BUS_NhaCungCap bus_NCC = new BUS_NhaCungCap();

        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNhaCungCap.DataSource = bus_NCC.getNCC();
        }
    }
}
