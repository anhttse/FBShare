using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FBShare.Model.Entities;

namespace FBShare.Control
{
    public partial class FacebookAccountControl : UserControl
    {
        public FacebookAccountControl()
        {
            InitializeComponent();
            bunifuCustomDataGrid1.BringToFront();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            addUserControl1.Visible = true;
            addUserControl1.BringToFront();
        }

        private void FacebookAccountControl_Load(object sender, EventArgs e)
        {


        }

        public void SetAndLoadGridAccount()
        {
            addUserControl1.LoadGridAccount(bunifuCustomDataGrid1);

        }
    }
}
