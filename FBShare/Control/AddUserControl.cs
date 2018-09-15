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
    public partial class AddUserControl : UserControl
    {
        public AddUserControl()
        {
            InitializeComponent();
        }

        private void AddUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAccountCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
