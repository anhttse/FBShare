using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBShare.Control
{
    public partial class ProcessControl : UserControl
    {
        public ProcessControl()
        {
            InitializeComponent();
        }

        private void AddLVItem(string key, string name, int value)
        {
            ListViewItem lvi = new ListViewItem();
            ProgressBar pb = new ProgressBar();

            lvi.SubItems[0].Text = name;
            lvi.SubItems.Add(value.ToString());
            lvi.SubItems.Add("");
            lvi.SubItems.Add(key);            // LV has 3 cols; this wont show
//            .Items.Add(lvi);
//
//            Rectangle r = lvi.SubItems[2].Bounds;
//            pb.SetBounds(r.X, r.Y, r.Width, r.Height);
//            pb.Minimum = 1;
//            pb.Maximum = 10;
//            pb.Value = value;
//            pb.Name = key;                   // use the key as the name
//            lvi.Controls.Add(pb);
        }

        private void UpdateItemValue(string key, int value)
        {
            ListViewItem lvi;
            ProgressBar pb;

//            // find the LVI based on the "key" in 
//            lvi = lv.Items.Cast<ListViewItem>().FirstOrDefault(q => q.SubItems[3].Text == key);
//            if (lvi != null)
//                lvi.SubItems[1].Text = value.ToString();
//
//            pb = lv.Controls.OfType<ProgressBar>().FirstOrDefault(q => q.Name == key);
//            if (pb != null)
//                pb.Value = value;
        }
    }
}
