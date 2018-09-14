using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBShare.Model.Fb
{
    public class Groups
    {
        public string id { get; set; }
        public string name { get; set; }
        public int member_count { get; set; }
        public string privacy { get; set; }
    }
}
