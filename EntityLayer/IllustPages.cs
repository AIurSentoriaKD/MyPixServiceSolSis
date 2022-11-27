using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class IllustPages
    {
        private int parent_illust;
        private int page_number;
        private string large_dir;

        public int Parent_illust { get => parent_illust; set => parent_illust = value; }
        public int Page_number { get => page_number; set => page_number = value; }
        public string Large_dir { get => large_dir; set => large_dir = value; }
    }
}
