using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Illust
    {
        private int id;
        private string title;
        private int sanity;
        private int author_id;
        private string illust_type;
        private int is_nsfw;
        private string thumb_dir;
        private string ugoira_dir;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public int Sanity { get => sanity; set => sanity = value; }
        public int Author_id { get => author_id; set => author_id = value; }
        public string Illust_type { get => illust_type; set => illust_type = value; }
        public int Is_nsfw { get => is_nsfw; set => is_nsfw = value; }
        public string Thumb_dir { get => thumb_dir; set => thumb_dir = value; }
        public string Ugoira_dir { get => ugoira_dir; set => ugoira_dir = value; }
    }
}
