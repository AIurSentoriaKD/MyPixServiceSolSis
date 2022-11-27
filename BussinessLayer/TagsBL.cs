using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class TagsBL : Interfaces.I_Tags
    {
        private readonly DatosSQL capadatos = new DatosSQL(); // OJO

        public bool EditIllustsTags(int illust_id, int codUser, string operation = "ADD", string tag_name = "")
        {
            if (operation.Equals("REMOVE")){
                DataRow resRemove = capadatos.TraerDataRow("spTagManageRemove", tag_name, illust_id, codUser);
                if (resRemove["CodError"].Equals("0"))
                    return true;
                else return false;
            }
            DataRow resAdd = capadatos.TraerDataRow("spTagManageAdd", tag_name,illust_id,codUser);
            if (resAdd["CodError"].Equals("0"))
                return true;
            else return false;
        }

        public DataTable GetIllustsAuthorTags(int codAuthor)
        {
            return capadatos.TraerDataTable("spGetIllustsAuthorTags", codAuthor);
        }

        public DataTable GetIllustsTags(int illust_id)
        {
            return capadatos.TraerDataTable("spGetIllustTags", illust_id);
        }

        public DataTable GetPopularTags()
        {
            return capadatos.TraerDataTable("spGetPopularTags");
        }

        public DataTable GetPreferredTags(int codUser)
        {
            return capadatos.TraerDataTable("spGetPreferredTags", codUser);
        }
    }
}
