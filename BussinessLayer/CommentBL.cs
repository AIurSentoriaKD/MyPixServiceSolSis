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
    public class CommentBL : Interfaces.I_Comment
    {
        private readonly DatosSQL capadatos = new DatosSQL(); // OJO

        public bool AddNewCommentOn(Comments comments, bool Is_response = false)
        {
            // la mayor parte de la logica la hace el procedure
            DataRow dr = capadatos.TraerDataRow("spAddNewCommentTo", comments.Illust_id, comments.Post_id, comments.Author_id, comments.Parent_id, comments.Emoji_id, comments.Comment_content);
            if (dr["CodError"].Equals("1"))
                return false;
            else return true;
        }

        public DataTable GetCommentsFrom(string origin_id, string type_require)
        {
            // type :: ILLUST || POST
            return capadatos.TraerDataTable("spGetCommentsFrom", origin_id, type_require);
        }
    }
}
