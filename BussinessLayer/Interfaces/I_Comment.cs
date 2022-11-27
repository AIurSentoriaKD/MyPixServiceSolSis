using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    interface I_Comment
    {
        // Obtener comentarios de una illust o post
        DataTable GetCommentsFrom(string origin_id, string type_require);

        // Agregar comentario a una illust o post
        bool AddNewCommentOn(Comments comments, bool Is_response = false);

    }
}
