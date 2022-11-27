using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AlbumIllust
    {
        private int album_id;
        private int illust_id;

        public int Album_id { get => album_id; set => album_id = value; }
        public int Illust_id { get => illust_id; set => illust_id = value; }
    }
}
