using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Request
    {
        // esta clase representa a quien se le pidio el request
        private int author_id;
        private int requester_id;
        private string requester_comment;

        public int Author_id { get => author_id; set => author_id = value; }
        public int Requester_id { get => requester_id; set => requester_id = value; }
        public string Requester_comment { get => requester_comment; set => requester_comment = value; }
    }
}
