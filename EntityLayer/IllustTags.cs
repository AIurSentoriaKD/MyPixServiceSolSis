using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class IllustTags
    {
        private string tag_name;
        private string illust_id;

        public string Tag_name { get => tag_name; set => tag_name = value; }
        public string Illust_id { get => illust_id; set => illust_id = value; }
    }
}
