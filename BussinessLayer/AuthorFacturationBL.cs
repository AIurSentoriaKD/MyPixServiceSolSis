using CapaDatos;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class AuthorFacturationBL : Interfaces.I_AuthorFacturation, Interfaces.I_FacturationCard
    {
        private readonly DatosSQL capadatos = new DatosSQL(); // OJO
        // I_AuthorFacturation
        public bool AuthorFacturationAdd(AuthorFacturation authorFacturation)
        {
            DataRow dataRow = capadatos.TraerDataRow("spAuthorFacturationAdd", authorFacturation.Author_id, authorFacturation.Fact_address, authorFacturation.Fact_postal, authorFacturation.Fact_country, authorFacturation.Balance, authorFacturation.Card_id);
            if (dataRow["CodError"].Equals("0"))
                return true;
            else return false;
        }

        public DataRow FactInfo(string codUser)
        {
            return capadatos.TraerDataRow("spFactInfoUser", codUser);
        }

        public bool FactStatus(string codUser)
        {
            DataRow dr = capadatos.TraerDataRow("spFactStatusUser", codUser);
            if (dr["CodError"].Equals("0"))
                return true;
            else return false;
        }

        public string FacturationBalance(string codUser)
        {
            DataRow dr = capadatos.TraerDataRow("spFacturationBalance", codUser);
            if (dr["CodError"].Equals("0"))
                return dr["Balance"].ToString();
            else return dr["Mensaje"].ToString();
        }

        public bool FacturationCommisionOpens(string codUser)
        {
            DataRow dr = capadatos.TraerDataRow("spFacturationCommisionOpens", codUser);
            if (dr["CodError"].Equals("0"))
                return true;
            else return false;
        }

        public bool FacturationInfoUpdate(string codUser, string[] parametros)
        {
            // TODO
            throw new NotImplementedException();
        }

        // I_FacturationCard
        public string FacturationCardAddNew(FacturationCard facturationCard)
        {
            DataRow dr = capadatos.TraerDataRow("spFacturationCardAddNew", facturationCard.Card_number, facturationCard.Card_date);
            if (dr["CodError"].Equals("0"))
            {
                // retorna el id de la tarjeta insertada como string,
                return dr["IdTarjeta"].ToString();
            }
            else return dr["Mensaje"].ToString();
        }
    }
}
