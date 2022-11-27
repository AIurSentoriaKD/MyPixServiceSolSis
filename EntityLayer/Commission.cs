using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Commission
    {
        // comm id autoincrement
        // illust id cuando se termina la comision
        private int author_id;
        private string details;
        // comm_date es la fecha en la que se pidió
        private string deliver_date;
        private string end_date;
        private string status;
        private int commissioner_id;

        public int Author_id { get => author_id; set => author_id = value; }
        public string Details { get => details; set => details = value; }
        public string Deliver_date { get => deliver_date; set => deliver_date = value; }
        public string End_date { get => end_date; set => end_date = value; }
        public string Status { get => status; set => status = value; }
        public int Commissioner_id { get => commissioner_id; set => commissioner_id = value; }
    }
}
