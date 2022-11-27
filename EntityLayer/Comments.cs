using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Comments
    {
        private int illust_id;
        private int post_id;
        private int author_id;
        private int parent_id;
        private int emoji_id;
        private string comment_content;

        public int Illust_id { get => illust_id; set => illust_id = value; }
        public int Post_id { get => post_id; set => post_id = value; }
        public int Author_id { get => author_id; set => author_id = value; }
        public int Parent_id { get => parent_id; set => parent_id = value; }
        public int Emoji_id { get => emoji_id; set => emoji_id = value; }
        public string Comment_content { get => comment_content; set => comment_content = value; }
    }
}
