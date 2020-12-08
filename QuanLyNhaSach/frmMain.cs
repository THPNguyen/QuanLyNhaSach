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

        public void closeAllForm(Form form)
        {
            for (int x = 0; x < Application.OpenForms.Count; x++)
            {
                if (Application.OpenForms[x] != this)
                {
                    Application.OpenForms[x].Close();
                }
            }
        }

        public frmMain()
        {
            InitializeComponent();
            init();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        

        public void init()
        {
            btnSubMenu1.Image = Resources.down_arrow;
            pnlDropMenu1.Visible = false;
        }

        Boolean checkDropMenu1 = false;

        private void btnSach_SubMenu_Click_1(object sender, EventArgs e)
        {
            if (checkDropMenu1)
            {
                btnSach_SubMenu.Image = Resources.down_arrow;
                pnlDropMenu1.Visible = false;
                checkDropMenu1 = !checkDropMenu1;
            }
            else
            {
                btnSach_SubMenu.Image = Resources.play_arrow;
                pnlDropMenu1.Visible = true;
                checkDropMenu1 = !checkDropMenu1;
                closeAllForm(null);
            }
            frmSach frm_sach = new frmSach()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            closeAllForm(frm_sach);
            this.pnlContainer.Controls.Add(frm_sach);
            frm_sach.Show();

        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNCC_Submenu_Click(object sender, EventArgs e)
        {
            //if (checkDropMenu1)
            //{
            //    btnSach_SubMenu.Image = Resources.down_arrow;
            //    pnlDropMenu1.Visible = false;
            //    checkDropMenu1 = !checkDropMenu1;
            //}
            //else
            //{
            //    btnSach_SubMenu.Image = Resources.play_arrow;
            //    pnlDropMenu1.Visible = true;
            //    checkDropMenu1 = !checkDropMenu1;
            //    closeAllForm(null);
            //}
            frmNhaCungCap frm_NCC = new frmNhaCungCap()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            closeAllForm(frm_NCC);
            this.pnlContainer.Controls.Add(frm_NCC);
            frm_NCC.Show();
        }
    }
}
