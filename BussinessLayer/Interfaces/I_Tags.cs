using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    interface I_Tags
    {
        // Obtener etiquetas mas populares
        DataTable GetPopularTags();

        // Obtener etiquetas preferidas del usuario
        DataTable GetPreferredTags(int codUser);

        // Obtener etiquetas de las publicaciones de un autor 
        DataTable GetIllustsAuthorTags(int codAuthor);

        // Obtener etiquetas de una ilustracion
        DataTable GetIllustsTags(int illust_id);

        // Editar etiquetas de una ilustracion
        bool EditIllustsTags(int illust_id, int codUser, string operation="ADD", string tag_name = "");
        
    }
}
