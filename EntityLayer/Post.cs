using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Post
    {
        private int author_id;
        private string post_content;

        public int Author_id { get => author_id; set => author_id = value; }
        public string Post_content { get => post_content; set => post_content = value; }
    }
}
