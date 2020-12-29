using QuanLyNhaSach.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frmMain : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
        );              

        public frmMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imsSach_Click(object sender, EventArgs e)
        {
        
        }

        private void imsNhaCungCap_Click(object sender, EventArgs e)
        {
            ControlNhaCungCap ctrl = new ControlNhaCungCap();
            ProcessGUI.CallContainer(pnlContainer,ctrl);
        }

        private void imsTheLoai_Click(object sender, EventArgs e)
        {
            ControlTheLoai ctrl = new ControlTheLoai();
            ProcessGUI.CallContainer(pnlContainer, ctrl);
        }

        private void imsHoaDon_Click(object sender, EventArgs e)
        {
            ControlHoaDon ctrl = new ControlHoaDon();
            ProcessGUI.CallContainer(pnlContainer, ctrl);
        }

        private void imsKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void imsNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnSach_SubMenu_Click(object sender, EventArgs e)
        {
            ControlBanSach ctrl = new ControlBanSach();
            ProcessGUI.CallContainer(pnlContainer, ctrl);
        }
    }
}
