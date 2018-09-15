


using System;
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
            try
            {
                var obj = new { link = linkToShare, message = msg, privacy = "{ value: 'EVERYONE'}" };
                var rp = await _fb.PostTaskAsync($"{gId}/feed", obj);
                await Task.Delay(5000);
                return new {result = true};
            }
            catch (Exception e)
            {
                return new { result = true, msg = e.Message};
            }
        }

        public async Task<object> GetGroups()
        {
            var user = await GetUser();
            var rp = await _fb.GetTaskAsync<Result>("/me/groups?fields=id,name,privacy,member_count");
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
                        Privacy = x.privacy
                    }));
                }

                db.SaveChanges();
            }

            return rp;
        }

        private async Task<User> GetUser()
        {
            var rp = await _fb.GetTaskAsync<FbUser>("/me?fields=id,name");
            return new User { Id = rp.id, Name = rp.name, Token = _token };
        }
    }
}
