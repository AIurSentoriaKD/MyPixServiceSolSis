using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    interface I_Post
    {
        // Obtener una lista de post
        // propia o de otro usuario
        DataTable GetPostList(int codUser);

        // Realizar post
        bool AddNewPost(Post post);

        // Eliminar Post
        bool RemovePost(int post_id, int author_id);

        // Obtener lista de posts de usuarios seguidos
        DataTable GetSelfPostsList(int codUser);
    }
}
