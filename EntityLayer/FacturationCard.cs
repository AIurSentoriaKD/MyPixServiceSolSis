using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class FacturationCard
    {
        private string card_number;
        private string card_date;

        public string Card_number { get => card_number; set => card_number = value; }
        public string Card_date { get => card_date; set => card_date = value; }
    }
}
