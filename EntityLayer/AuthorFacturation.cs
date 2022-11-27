using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AuthorFacturation
    {
        private string author_id;
        private string fact_address;
        private string fact_postal;
        private string fact_country;
        private float balance;
        private int card_id;

        public string Author_id { get => author_id; set => author_id = value; }
        public string Fact_address { get => fact_address; set => fact_address = value; }
        public string Fact_postal { get => fact_postal; set => fact_postal = value; }
        public string Fact_country { get => fact_country; set => fact_country = value; }
        public float Balance { get => balance; set => balance = value; }
        public int Card_id { get => card_id; set => card_id = value; }
    }
}
