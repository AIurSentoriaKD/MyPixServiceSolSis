using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Album
    {
        private int owner_id;
        private string album_name;
        private int public_status;

        public int Owner_id { get => owner_id; set => owner_id = value; }
        public string Album_name { get => album_name; set => album_name = value; }
        public int Public_status { get => public_status; set => public_status = value; }
    }
}
