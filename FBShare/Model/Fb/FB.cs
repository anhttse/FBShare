


using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Facebook;
using FBShare.Model.Entities;

namespace FBShare.Model.Fb
{
    public class Fb
    {
        private static readonly  FacebookClient _fb = new FacebookClient();
        private readonly string _token;
        public Fb(string token)
        {
            _token = token;
            _fb.AccessToken = token;
        }

//        public async Task<object> Share(string linkToShare, string gId,string msg)
//        {
//            var obj = new {link = linkToShare, message= msg, privacy = "{ value: 'EVERYONE'}"};
////            var rp = await _fb.PostAsJsonAsync($"{gId}/feed", obj);
//            return rp;   
//        }

        public async Task<object> GetGroups()
        {
            var rp = await _fb.GetTaskAsync<Result>("/me/groups?fields=id,name,privacy,member_count");
            using (var db = new FbsEntities())
            {

                var token = db.Tokens.FirstOrDefault(x => x.Value == _token);
                if (token != null)
                {
                    db.Groups.AddRange(rp.data.Select(x => new Group()
                    {
                        Name = x.name,
                        TokenId = token.Id,
                        GroupId = x.id,
                        Member_count = x.member_count,
                        Privacy = x.privacy
                    }));
                }
                else
                {
                    var rs = db.Tokens.Add(new Token() {Value = _token});
                    db.Groups.AddRange(rp.data.Select(x => new Group()
                    {
                        Name = x.name,
                        TokenId = rs.Id,
                        GroupId = x.id,
                        Member_count = x.member_count,
                        Privacy = x.privacy
                    }));
                }

                db.SaveChanges();
            }
            
            return rp;
        }
    }
}
