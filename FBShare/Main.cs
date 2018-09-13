using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FBShare.Model.Fb;

namespace FBShare
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var token = txtToken.Text;
            var fb = new Fb(token);
            var rs = fb.GetGroups();
        }

        //        private  Task RunAsync()
        //        {
        //            var fb = new Fb();
        //            fb.Token = txtToken.Text;
        ////            var rs = await fb.Share(txtLink.Text, "2252328145000285", "SHARE");
        //            var fb = new Fb();
        //            fb.Token = txtToken.Text;
        //        }
    }
}
