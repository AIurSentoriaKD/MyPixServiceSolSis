using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AuthorRequest
    {
        // esta clase representa a quien PIDE la request
        private int requester_id;

        public int Requester_id { get => requester_id; set => requester_id = value; }
    }
}
