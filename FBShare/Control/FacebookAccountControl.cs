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
    }
}
