using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using FBShare.Model.Entities;
using FBShare.Model.Fb;
namespace FBShare.Control
{
    public partial class AddUserControl : UserControl
    {
        private readonly FbsEntities _db;
        private Fb _fb;
        private string _action;
        private string _id;
        public AddUserControl()
        {
            _db = new FbsEntities();
            InitializeComponent();
        }

        private void AddUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAccountCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            var token = txtToken.Text;
            switch (_action)
            {
                case "CREATE":
                    _fb = new Fb(token);
                    var rs = _fb.GetGroups();
                    break;
                case "UPDATE":
                    using (var db = new FbsEntities())
                    {
                        var cUser = db.Users.FirstOrDefault(x => x.Id == _id);
                        if (cUser != null)
                        {
                            cUser.Token = token;
                            db.SaveChanges();
                        }
                    }
                    break;
            }


        }

        public void SetAction(string action, string id = null)
        {
            _id = id;
            _action = action;
        }
        public void LoadGridAccount(DataGridView gridView)
        {
            using (var db = new FbsEntities())
            {
                var users = db.Users.ToList();
                var bdList = new BindingList<object>();
                var count = 0;
                foreach (var us in users)
                {
                    bdList.Add(new { no = ++count, Id = us.Id, Name = us.Name, fbGroup = us.Groups.Count });
                }

                gridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridView.DataSource = bdList;
            }

        }
    }
}
