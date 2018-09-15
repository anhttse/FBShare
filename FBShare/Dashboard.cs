using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using FBShare.Model.Entities;

namespace FBShare
{
    public partial class Dashboard : Form
    {
        private int _move;
        private int _moveX;
        private int _moveY;
        public Dashboard()
        {
            _move = 0;
            InitializeComponent();
            activeSlide.Height = button1.Height;
            activeSlide.Top = button1.Top;
            shareControl1.LoadUserCb();
            shareControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activeSlide.Height = button1.Height;
            activeSlide.Top = button1.Top;
            shareControl1.LoadUserCb();
            shareControl1.BringToFront();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            activeSlide.Height = btnAccount.Height;
            activeSlide.Top = btnAccount.Top;
            facebookAccountControl1.SetAndLoadGridAccount();
            facebookAccountControl1.BringToFront();
        }
        private void btnMenuCaption_Click(object sender, EventArgs e)
        {
            activeSlide.Height = btnMenuCaption.Height;
            activeSlide.Top = btnMenuCaption.Top;
            captionControl1.LoadGridCaption();
            captionControl1.BringToFront();
        }

        private void btnMenuProcess_Click(object sender, EventArgs e)
        {
            activeSlide.Height = btnMenuProcess.Height;
            activeSlide.Top = btnMenuProcess.Top;
            processControl1.BringToFront();
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _move = 1;
            _moveX = e.X;
            _moveY = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (_move == 1)
            {
                var location = this.Location;
                SetDesktopLocation(location.X+(e.X-_moveX), location.Y + (e.Y - _moveY));
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            _move = 0;
        }
    }
}
