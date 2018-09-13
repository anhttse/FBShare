


using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Facebook;

namespace FBShare.Model.Fb
{
    public class Fb
    {
        private static readonly  FacebookClient _fb = new FacebookClient();
        public Fb(string token)
        {
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

            var rp = await _fb.GetTaskAsync<Result>("/me/groups");
            return rp;
        }
    }
}
