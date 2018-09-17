


using System;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using FBShare.Model.Entities;

namespace FBShare.Model.Fb
{
    public class Fb
    {
        private static FacebookClient _fb;
        private readonly string _token;
        public Fb(string token)
        {
            _fb = new FacebookClient();
            _token = token;
            _fb.AccessToken = token;
        }

        public async Task<object> Share(string linkToShare, string gId, string msg)
        {
//            gId = "341754012625518";
//            msg += DateTime.Now.ToString(CultureInfo.InvariantCulture);
            try
            {
                var obj = new { link = linkToShare, message = msg};
                var rp = await _fb.PostTaskAsync($"{gId}/feed", obj);
                await Task.Delay(60000);
                return new {result = true};
            }
            catch (Exception e)
            {
                return new { result = false, msg = e.Message};
            }
        }

        public object GetGroups()
        {
            var user = GetUser();
            var rp = _fb.GetTaskAsync<Result>("/me/groups?fields=id,name,privacy,member_count").Result;
            using (var db = new FbsEntities())
            {
                var cUser = db.Users.FirstOrDefault(x => x.Id == user.Id);
                if (cUser != null)
                {
                    db.Groups.AddRange(rp.data.Select(x => new Group()
                    {
                        Name = x.name,
                        UserId = cUser.Id,
                        Id = x.id,
                        Member_count = x.member_count,
                        Privacy = x.privacy
                    }));
                }
                else
                {
                    var rs = db.Users.Add(user);
                    db.Groups.AddRange(rp.data.Select(x => new Group()
                    {
                        Name = x.name,
                        UserId = rs.Id,
                        Id = x.id,
                        Member_count = x.member_count,
                        Privacy = x.privacy,
                        Enable = true
                    }));
                }

                var rss = db.SaveChanges();
            }

            return rp;
        }

        private User GetUser()
        {
            var rp = _fb.GetTaskAsync<FbUser>("/me?fields=id,name").Result;
            return new User { Id = rp.id, Name = rp.name, Token = _token, ImageUrl  = rp.picture};
        }

        public async Task<int> UpdateUser()
        {
            var rp = await _fb.GetTaskAsync<FbUser>("/me?fields=id,name,picture");
            using (var db = new FbsEntities())
            {
                var cUser = db.Users.FirstOrDefault(x => x.Id == rp.id);
                if (cUser != null)
                {
                    cUser.Token = _token;
                    cUser.Name = rp.name;
                    cUser.ImageUrl = rp.picture;
                    db.SaveChanges();
                    return 1;
                }
            }
            return 0;
        }
    }
}
