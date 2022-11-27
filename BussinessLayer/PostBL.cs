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
    public class PostBL : Interfaces.I_Post
    {
        private readonly DatosSQL capadatos = new DatosSQL(); // OJO
        // Realizar post
        public bool AddNewPost(Post post)
        {
            
            DataRow dr = capadatos.TraerDataRow("spCreateNewPost", post.Author_id, post.Post_content);
            if (dr["CodError"].Equals("0"))
                return true;
            else return false;
        }
        // Obtener una lista de post
        // propia o de otro usuario
        public DataTable GetPostList(int codUser)
        {
            return capadatos.TraerDataTable("spListUserPosts", codUser);
        }
        // Obtener lista de posts de un usuario
        public DataTable GetSelfPostsList(int codUser)
        {
            return capadatos.TraerDataTable("spListUserPosts", codUser);
        }
        // Eliminar Post
        public bool RemovePost(int post_id, int author_id)
        {
            DataRow dr = capadatos.TraerDataRow("spDeletePost", post_id, author_id);
            if (dr["CodError"].Equals("0"))
                return true;
            else return false;
        }
    }
}
