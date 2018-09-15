using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FBShare.Model.Entities;
using FBShare.Model.Fb;
using FBShare.Model.Thread;

namespace FBShare.Control
{
    public partial class ShareControl : UserControl
    {
        private List<string> _captions;
        private Fb _fb;
        private List<MultiThread> _runningThread;
        private string _id;
        public ShareControl()
        {
            _runningThread = new List<MultiThread>();
            InitializeComponent();
        }

        private void ShareControl_Load(object sender, EventArgs e)
        {

        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            _id = cbFbAccount.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(_id)) return;
            using (var db = new FbsEntities())
            {
                _captions = db.Captions.Select(x => x.Title).ToList();
                var thread = new Thread(ShareThread);
                if (_runningThread.FirstOrDefault(x => x.Id == _id) == null)
                    thread.Start();
                if (thread.IsAlive)
                    _runningThread.Add(new MultiThread { Id = _id, Thread = thread });
            }
        }

        private async void ShareThread()
        {

            using (var db = new FbsEntities())
            {
                var token = db.Users.Where(x => x.Id == _id).Select(x => x.Token).FirstOrDefault();
                var groups = db.GetGroups(_id, null, "OPEN");
                if (groups == null || token == null) return;
                var link = txtLink.Text;
                _fb = new Fb(token);
                var rand = new Random();
                foreach (var gr in groups)
                {
                    var msg = _captions[rand.Next(_captions.Count - 1)];
                    var rp = await _fb.Share(link, gr.Id, msg);
                    var rs = rp.GetType().GetProperty("result")?.GetValue(rp);
                    if (rs != null && !(bool)rs)
                    {
                        var ms = rp.GetType().GetProperty("msg")?.GetValue(rp).ToString();
                        MessageBox.Show(ms, @"Error");
                        var item = _runningThread.SingleOrDefault(x => x.Id == _id);
                        _runningThread.Remove(item);
                        break;

                    }
                }
            }
        }

        public void LoadUserCb()
        {
            using (var db = new FbsEntities())
            {
                var lstAccount = db.Users.ToList();
                lstAccount[0].Name = lstAccount[0].Name;
                cbFbAccount.DataSource = lstAccount;
                cbFbAccount.DisplayMember = "Name";
                cbFbAccount.ValueMember = "Id";
            }
        }
    }
}
