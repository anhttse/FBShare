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
using FBShare.Model.Fb;

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
            addUserControl1.SetAction("CREATE");
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

        private void btnAccountUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = bunifuCustomDataGrid1.SelectedRows[0].DataBoundItem;
                var propertyInfo = obj.GetType().GetProperty("Id");
                var value = propertyInfo.GetValue(obj, null).ToString();
                addUserControl1.SetAction("UPDATE", value);
                addUserControl1.Visible = true;
                addUserControl1.BringToFront();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Select 1 row to update");
            }

        }
    }
}
