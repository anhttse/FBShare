using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBShare
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            activeSlide.Height = button1.Height;
            activeSlide.Top = button1.Top;
            shareControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activeSlide.Height = button1.Height;
            activeSlide.Top = button1.Top;
            shareControl1.BringToFront();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            activeSlide.Height = btnAccount.Height;
            activeSlide.Top = btnAccount.Top;
            facebookAccountControl1.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Hide();
            WindowState = FormWindowState.Minimized;
            notifyIcon.Visible = true;
        }
    }
}
