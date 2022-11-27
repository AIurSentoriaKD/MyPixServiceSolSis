using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class CommissionDetail
    {
        private int comm_id;
        private int fact_id;
        private float price;

        public int Comm_id { get => comm_id; set => comm_id = value; }
        public int Fact_id { get => fact_id; set => fact_id = value; }
        public float Price { get => price; set => price = value; }
    }
}
