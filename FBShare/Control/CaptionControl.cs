using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FBShare.Model.Entities;

namespace FBShare.Control
{
    public partial class CaptionControl : UserControl
    {
        public CaptionControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var cap = txtAddCaption.Text;
            if (string.IsNullOrEmpty(cap)) return;
            using (var db = new FbsEntities())
            {
                db.Captions.Add(new Caption { Title = cap });
                db.SaveChanges();
            }

            LoadGridCaption();
            panel2.BringToFront();
        }

        private void btnAddCaptionCancel_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void btnAddCaption_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }
        public void LoadGridCaption()
        {
            using (var db = new FbsEntities())
            {
                var caps = db.Captions.ToList();
                var bdList = new BindingList<object>();
                var count = 0;
                foreach (var cap in caps)
                {
                    bdList.Add(new { no = ++count, Title = cap.Title});
                }
                bunifuCustomDataGrid1.DataSource = bdList;
            }

        }
    }
}
