using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBShare.Model.Fb
{
    public class Result
    {
        public List<Data> data { get; set; }
        protected object paging { get; set; }
    }

}
